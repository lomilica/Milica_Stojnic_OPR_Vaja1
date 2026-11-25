using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//2.	Ustvari razred Denarnica, ki ima podatek o stanju. Napiši metodi za dvig in polog denarja ter metodo za
//izpis stanja v denarnici. Napiši privzeti konstruktor, ki nastavi stanje denarnice na 0. Napiši kopirni konstruktor,
//ki prekopira stanje druge denarnice. Napiši še pretvorbeni konstruktor, ki nastavi začetno stanje v denarnici na želeno. 

class Denarnica
{
    private double stanje;

    // Privzeti konstruktor
    public Denarnica()
    {
        stanje = 0;
        Console.WriteLine("Izvedel se je privzeti konstruktor.");
    }

    // Kopirni konstruktor
    public Denarnica(Denarnica druga)
    {
        stanje = druga.stanje;
        Console.WriteLine("Izvedel se je kopirni konstruktor.");
    }

    // Pretvorbeni konstruktor
    public Denarnica(double zacetnoStanje)
    {
        if (zacetnoStanje < 0)
        {
            stanje = 0;
        }
        else
        {
            stanje = zacetnoStanje;
        }

        Console.WriteLine("Izvedel se je pretvorbeni konstruktor.");
    }


    public bool Dvig(double vsotaDenarja)
    {
        if(stanje >= vsotaDenarja)
        {
            return true;
            stanje = stanje - vsotaDenarja;
        }
        else
        {
            return false;
        }
    }

    public void Polog(double vsotaDenarja)
    {
        Console.WriteLine("Vnesi velikost pologa: ");
        int polog = int.Parse(Console.ReadLine());

        if(polog > 0)
        {
            stanje = stanje + polog;
        }
        else
        {
            stanje = stanje;
        }
    }

    public double VrniStanje()
    {
        return stanje;
    }

    ~Denarnica()
    {
        Console.WriteLine("Izvedel se je destruktor.");
    }

}

class Program
{
    static void Main(string[] args)
    {
        // 1. Mirko - privzeti konstruktor
        Denarnica mirko = new Denarnica();

        // 2. Marko - kopirni konstruktor
        Denarnica marko = new Denarnica(mirko);

        // 3. Darko - pretvorbeni konstruktor
        Denarnica darko = new Denarnica(100);

        Console.WriteLine();
        Console.WriteLine("MIRKO");

        mirko.Polog(50);
        Console.WriteLine("Stanje po pologu: " + mirko.VrniStanje());

        bool dvigMirko = mirko.Dvig(20);
        Console.WriteLine("Dvig uspešen: " + dvigMirko);
        Console.WriteLine("Stanje: " + mirko.VrniStanje());

        Console.WriteLine();
        Console.WriteLine("MARKO");
       
        marko.Polog(30);
        Console.WriteLine("Stanje po pologu: " + marko.VrniStanje());

        bool dvigMarko = marko.Dvig(10);
        Console.WriteLine("Dvig uspešen: " + dvigMarko);
        Console.WriteLine("Stanje: " + marko.VrniStanje());

        Console.WriteLine();
        Console.WriteLine("DARKO");

        darko.Polog(50);
        Console.WriteLine("Stanje po pologu: " + darko.VrniStanje());

        bool dvigDarko = darko.Dvig(25);
        Console.WriteLine("Dvig uspešen: " + dvigDarko);
        Console.WriteLine("Stanje: " + darko.VrniStanje());

        Console.WriteLine();
        Console.WriteLine("PREPOVEDANE VREDNOSTI");

        Console.WriteLine("Poskus negativnega pologa:");
        mirko.Polog(-50);
        Console.WriteLine("Stanje Mirko: " + mirko.VrniStanje());

        Console.WriteLine("Poskus prevelikega dviga:");
        bool rezultat = mirko.Dvig(1000);
        Console.WriteLine("Dvig uspešen: " + rezultat);
        Console.WriteLine("Stanje Mirko: " + mirko.VrniStanje());

        Console.WriteLine("Poskus negativnega dviga:");
        bool rezultat2 = mirko.Dvig(-20);
        Console.WriteLine("Dvig uspešen: " + rezultat2);
        Console.WriteLine("Stanje Mirko: " + mirko.VrniStanje());

        Console.WriteLine();
        Console.WriteLine("Pritisni Enter za konec programa.");
        Console.ReadLine();
    }
}
