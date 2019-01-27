using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi
{
    public class Korisnik
    {
        protected string korisnickoIme;
        protected string zaporka;

        public Korisnik()
        {
            korisnickoIme = "nedefinirano";
            zaporka = "12345";
            Console.WriteLine("Poziviam inicijalni konstruktor korisnika ");
        }

        public Korisnik(string korisnickoIme, string zaporka)
        {
            this.korisnickoIme = korisnickoIme;
            this.zaporka = zaporka;
        }

        public virtual string PredstaviSe() //polimorfizam virtual
        {
            return String.Format("Ja sam korisnik {0} zaporka mi je {1}", korisnickoIme, zaporka);
        }

        public void Zadaj(string korisnickoIme, string zaporka)
        {
            this.korisnickoIme = korisnickoIme;
            this.zaporka = zaporka;
        }
    }
}
