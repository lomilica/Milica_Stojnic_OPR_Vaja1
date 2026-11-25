using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.	Ustvari razred Semafor. Z ustreznimi metodami naj omogoča prižiganje luči in izpis trenutno prižgane
//luči. Dodaj še metodo, ki vrača true, če trenutno lahko prečkamo cesto in false, če je ne smemo. V glavnem
//programu ustvari nekaj objektov razreda semafor in demonstriraj uporabo.

namespace Naloga03
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Semafor semafor1 = new Semafor();
                Semafor semafor2 = new Semafor();
                Semafor semafor3 = new Semafor();

                Console.WriteLine("SEMAFOR 1");

                semafor1.PrizgiRdeco();
                semafor1.IzpisiLucko();
                Console.WriteLine("Lahko prečkamo cesto: " + semafor1.LahkoPreckamoCesto());

                Console.WriteLine();

                Console.WriteLine("SEMAFOR 2 ");

                semafor2.PrizgiRumeno();
                semafor2.IzpisiLucko();
                Console.WriteLine("Lahko prečkamo cesto: " + semafor2.LahkoPreckamoCesto());

                Console.WriteLine();

                Console.WriteLine("SEMAFOR 3");

                semafor3.PrizgiZeleno();
                semafor3.IzpisiLucko();
                Console.WriteLine("Lahko prečkamo cesto: " + semafor3.LahkoPreckamoCesto());

                Console.WriteLine();

                Console.WriteLine("SPREMEMBA SEMAFORJA 1");

                semafor1.PrizgiZeleno();
                semafor1.IzpisiLucko();
                Console.WriteLine("Lahko prečkamo cesto: " + semafor1.LahkoPreckamoCesto());
            }
        }
    }
    


    class Semafor
    {
        private string lucka;

        public Semafor()
        {
            lucka = "rdeca";
        }

        public void PrizgiRdeco()
        {
            lucka = "rdeca";
        }

        public void PrizgiRumeno()
        {
            lucka = "rumena";
        }

        public void PrizgiZeleno()
        {
            lucka = "zelena";
        }

        public void IzpisiLucko()
        {
            Console.WriteLine("Trenutno je prižgana: " + lucka);
        }

        
        public bool LahkoPreckamoCesto()
        {
            if (lucka == "zelena")
            {
                return true;
            }

            return false;
        }
    }

