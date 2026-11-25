using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.	Ustvari razred Oseba. Podatki so naslednji:
//ime: niz
//priimek: niz
//datumRojstva: razred Datum iz prejšnje naloge

//Napiši privzeti konstruktor, ki vse tri vrednosti nastavi na null, konstruktor, ki mu podaš podatke o osebi in kopirni konstruktor. Za vse tri podatke ustvari ustrezne lastnosti, pri datumu rojstva preverjaj, da ni kasnejši od današnjega dne. Če je, obvesti uporabnika preko standardnega izhoda in nastavi datumRojstva na današnji dan. Napiši metodo, ki izpiše podatke o osebi. Pri izpisu datuma uporabi metodo iz razreda Datum.

//V glavnem programu deklariraj tri objekte razreda Oseba. Uporabi različne konstruktorje. Izpiši podatke vseh oseb.


namespace Naloga06
{

class Oseba
    {
        private string ime;
        private string priimek;
        private Datum datumRojstva;
        
        public Oseba()
        {
            ime = null;
            priimek = null;
            datumRojstva = null;
        }
        
        public Oseba(string ime, string priimek, Datum datumRojstva)
        {
            this.ime = ime;
            this.priimek = priimek;

            Datum danes = new Datum(
                DateTime.Now.Day,
                DateTime.Now.Month,
                DateTime.Now.Year
            );

            if (datumRojstva != null &&
                (datumRojstva.Leto > danes.Leto ||
                datumRojstva.Leto == danes.Leto && datumRojstva.Mesec > danes.Mesec ||
                datumRojstva.Leto == danes.Leto && datumRojstva.Mesec == danes.Mesec && datumRojstva.Dan > danes.Dan))
            {
                Console.WriteLine("Datum rojstva ne more biti v prihodnosti.");
                this.datumRojstva = danes;
            }
            else
            {
                this.datumRojstva = datumRojstva;
            }
        }

        public Oseba(Oseba druga)
        {
            ime = druga.ime;
            priimek = druga.priimek;

            if (druga.datumRojstva != null)
            {
                datumRojstva = new Datum(
                    druga.datumRojstva.Dan,
                    druga.datumRojstva.Mesec,
                    druga.datumRojstva.Leto
                );
            }
            else
            {
                datumRojstva = null;
            }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }


        public string Priimek
        {
            get { return priimek; }
            set { priimek = value; }
        }

        public Datum DatumRojstva
        {
            get { return datumRojstva; }
            set { datumRojstva = value; }
        }

        public void Izpisi()
        {
            Console.WriteLine("Ime: " + ime);
            Console.WriteLine("Priimek: " + priimek);

            Console.Write("Datum rojstva: ");

            if (datumRojstva != null)
            {
                datumRojstva.Izpisi();
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }

    using System;

class Program
    {
        static void Main(string[] args)
        {
            Oseba oseba1 = new Oseba();

            oseba1.Ime = "Ana";
            oseba1.Priimek = "Novak";
            oseba1.DatumRojstva = new Datum(15, 6, 2008);


            Oseba oseba2 = new Oseba(
                "Maja",
                "Kovac",
                new Datum(20, 3, 2007)
            );

            Oseba oseba3 = new Oseba(oseba2);


            
            Console.WriteLine("----- OSEBA 1 -----");
            oseba1.Izpisi();

            Console.WriteLine();

            Console.WriteLine("----- OSEBA 2 -----");
            oseba2.Izpisi();

            Console.WriteLine();

            Console.WriteLine("----- OSEBA 3 -----");
            oseba3.Izpisi();
        }
    }
}
