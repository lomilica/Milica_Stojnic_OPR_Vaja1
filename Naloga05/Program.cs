using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5.	Ustvari razred Datum. Razred naj vsebuje podatke o dnevu, mesecu in letu. Vsi so cela števila.
//Napiši privzeti konstruktor ki nastavi datum na 1.1.2000, in pretvorbeni konstruktor, ki ga nastavi na
//poljuben datum. Definiraj ustrezne lastnosti in jih uporabi v glavnem programu. Napiši metodo,
//ki preveri, ali je nastavljeni datum sploh veljaven. Če ni, obvesti uporabnika in ga nastavi na
//0.0.0. Napiši še metodo, ki izpiše datum.

namespace Naloga05
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Datum datum1 = new Datum();

            Console.WriteLine(" DATUM 1 ");

            datum1.Izpisi();


            Console.WriteLine();

            
            Datum datum2 = new Datum(15, 8, 2026);

            Console.WriteLine("DATUM 2");

            datum2.Izpisi();


            Console.WriteLine();

            Datum datum3 = new Datum();

            datum3.Dan = 25;
            datum3.Mesec = 12;
            datum3.Leto = 2026;

            Console.WriteLine("DATUM 3");

            datum3.Izpisi();


            Console.WriteLine();

            Console.WriteLine("PREVERJANJE DATUMA");

            datum2.PreveriDatum();
            datum2.Izpisi();


            Console.WriteLine();

            Datum datum4 = new Datum(31, 2, 2026);

            Console.WriteLine("NEVELJAVEN DATUM");

            datum4.PreveriDatum();
            datum4.Izpisi();
        }
    }


    class Datum
    {
        private int dan;
        private int mesec;
        private int leto;

      
        public Datum()
        {
            dan = 1;
            mesec = 1;
            leto = 2000;
        }

        
        public Datum(int dan, int mesec, int leto)
        {
            this.dan = dan;
            this.mesec = mesec;
            this.leto = leto;
        }

        public int Dan
        {
            get { return dan; }
            set { dan = value; }
        }

       
        public int Mesec
        {
            get { return mesec; }
            set { mesec = value; }
        }

       
        public int Leto
        {
            get { return leto; }
            set { leto = value; }
        }

        public void PreveriDatum()
        {
            bool veljaven = true;

            if (leto < 1)
            {
                veljaven = false;
            }

           
            if (mesec < 1 || mesec > 12)
            {
                veljaven = false;
            }

            
            if (dan < 1)
            {
                veljaven = false;
            }

            if (mesec >= 1 && mesec <= 12)
            {
                int steviloDni = DateTime.DaysInMonth(leto, mesec);

                if (dan > steviloDni)
                {
                    veljaven = false;
                }
            }

            if (!veljaven)
            {
                Console.WriteLine("Datum ni veljaven!");

                dan = 0;
                mesec = 0;
                leto = 0;
            }
        }

       
        public void Izpisi()
        {
            Console.WriteLine("Datum: " + dan + "." + mesec + "." + leto);
        }
    }
}
