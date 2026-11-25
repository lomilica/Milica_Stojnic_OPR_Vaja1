using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Ustvari razred Kvadrat1 z javnim podatkom stranica ter javnima metodama IzracunajPloscino in IzracunajObseg.

//	V glavnem programu ustvari dva objekta razreda Kvadrat1 in jima nastavi dve različni stranici ter izpiši ploščino in obseg obeh kvadratov.
//	Kaj se zgodi, če za dolžino stranico nastaviš negativno število?
//	Dodaj nov razred Kvadrat2 tako, da bo podatek stranica privaten in da bo imel javno metodo NastaviStranico, ki bo preverjala, ali je želena dolžina stranice negativna in jo bo v tem primeru nastavila na 0. Obe metodi za izračun naj ostaneta nespremenjeni.
//	V glavnem programu ustvari dva objekta razreda Kvadrat2 in jima nastavi dve različni stranici ter izpiši ploščino in obseg obeh kvadratov.
//	Kaj se zgodi, če za dolžino stranico nastaviš negativno število?


namespace Naloga01
{
      

    class Kvadrat1
    {
        public double stranica;

        public double IzracunajPloscino()
        {
            return stranica * stranica;
        }

        public double IzracunajObseg()
        {
            return 4 * stranica;
        }
    }
    class Program
    {
        static void Main(string[] args)
            {
                
                Kvadrat1 k1 = new Kvadrat1();
                Kvadrat1 k2 = new Kvadrat1();

                // Če nastavimo stranicu na negativno ploščina bo tudi negativna
                k1.stranica = 5;
                k2.stranica = 8;

                
                Console.WriteLine("Prvi kvadrat:");
                Console.WriteLine("Stranica: " + k1.stranica);
                Console.WriteLine("Ploščina: " + k1.IzracunajPloscino());
                Console.WriteLine("Obseg: " + k1.IzracunajObseg());

                Console.WriteLine();

                
                Console.WriteLine("Drugi kvadrat:");
                Console.WriteLine("Stranica: " + k2.stranica);
                Console.WriteLine("Ploščina: " + k2.IzracunajPloscino());
                Console.WriteLine("Obseg: " + k2.IzracunajObseg());
            }
        }
    }

namespace Naloga02
{

    class Kvadrat2
    {
        private double stranica;

        public void NastaviStranico(double novaStranica)
        {
            if (novaStranica < 0)
            {
                stranica = 0;
            }
            else
            {
                stranica = novaStranica;
            }
        }

        public double IzracunajPloscino()
        {
            return stranica * stranica;
        }

        public double IzracunajObseg()
        {
            return 4 * stranica;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat2 k1 = new Kvadrat2();
            Kvadrat2 k2 = new Kvadrat2();

            //Če nastavimo stranicu na negativno se spremeni na nič in dobijemo rezultat tudi 0
            k1.NastaviStranico(5);
            k2.NastaviStranico(8);

            Console.WriteLine("Prvi kvadrat:");
            Console.WriteLine("Ploščina: " + k1.IzracunajPloscino());
            Console.WriteLine("Obseg: " + k1.IzracunajObseg());

            Console.WriteLine();

            Console.WriteLine("Drugi kvadrat:");
            Console.WriteLine("Ploščina: " + k2.IzracunajPloscino());
            Console.WriteLine("Obseg: " + k2.IzracunajObseg());
        }
    }
}

