using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.Ustvari razred Stevec, ki vsebuje podatek vrednost in ima tri konstruktorje: v privzetem naj se vrednost
//nastavi na 0, v pretvorbenem na vrednost, ki je podana, v kopirnem pa na vrednost obstoječega objekta. Dodaj
//še metode za povečevanje vrednosti za 1, za zmanjševanje vrednosti za 1 in za izpis trenutne vrednosti.
//V glavnem programu ustvari nekaj objektov razreda števec in demonstriraj uporabo.


namespace Naloga04
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Stevec stevec1 = new Stevec();

            Console.WriteLine("STEVEC 1");
            stevec1.Izpisi();

            stevec1.Povecaj();
            stevec1.Povecaj();

            Console.WriteLine("Po dveh povečanjih:");
            stevec1.Izpisi();

            stevec1.Zmanjsaj();

            Console.WriteLine("Po zmanjšanju:");
            stevec1.Izpisi();


            Console.WriteLine();

            Stevec stevec2 = new Stevec(10);

            Console.WriteLine(" STEVEC 2 ");
            stevec2.Izpisi();

            stevec2.Povecaj();

            Console.WriteLine("Po povečanju:");
            stevec2.Izpisi();


            Console.WriteLine();

     
            Stevec stevec3 = new Stevec(stevec2);

            Console.WriteLine("STEVEC 3 ");
            stevec3.Izpisi();

            stevec3.Zmanjsaj();
            stevec3.Zmanjsaj();

            Console.WriteLine("Po dveh zmanjšanjih:");
            stevec3.Izpisi();
        }
    }

    class Stevec
    {
        private int vrednost;

        public Stevec()
        {
            vrednost = 0;
        }

        public Stevec(int vrednost)
        {
            this.vrednost = vrednost;
        }

        public Stevec(Stevec drug)
        {
            vrednost = drug.vrednost;
        }

        public void Povecaj()
        {
            vrednost++;
        }


        public void Zmanjsaj()
        {
            vrednost--;
        }

        public void Izpisi()
        {
            Console.WriteLine("Trenutna vrednost: " + vrednost);
        }
    }
}
