using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi
{
    public class Student:Korisnik
    {
        private int godinaStudija;

        public Student()
        {
            korisnickoIme = "student";
            zaporka = "99999";
            Console.WriteLine("Poziviam inicijalni " +
                "konstruktor studenta ");
        }
        public Student(string korIme,string zapo, int godinaStudija):base(korIme,zapo)
        {
            this.godinaStudija = godinaStudija;
        }

        public void ZadajGodinuStudija(int godinaStudija)
        {
            this.godinaStudija = godinaStudija;
        }
        public override string PredstaviSe()
        {
            return String.Format("Ja sam student {0},{2} godine studija, zaporka mi je {1}", korisnickoIme, zaporka,godinaStudija);

        }
    }
}
