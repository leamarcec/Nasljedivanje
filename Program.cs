using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba_2019_01_07.Razredi;


namespace nasljedivanje
{
    class Program
    {
        private static List<Korisnik>korisnici  =new List<Korisnik>();
        
        static void Main(string[] args)
        {
            Korisnik marko = new Korisnik();
            marko.Zadaj("mmarko@mev.hr", "55555");
            Console.WriteLine(marko.PredstaviSe());
            Console.WriteLine();

            Student ivan = new Student();
            Console.WriteLine(ivan.PredstaviSe());
            ivan.Zadaj("iivan@mev.hr", "0000");
            ivan.ZadajGodinuStudija(2);
            Console.WriteLine(ivan.PredstaviSe());
            Console.WriteLine();

            Student miro = new Student("miro", "12345", 3);
            miro.PredstaviSe();
            Console.WriteLine();




            Profesor pero = new Profesor();
            pero.Zadaj("ppero@mev.hr", "1111");
            pero.ZadajPredmete("OOP1, AISP, PAUP");
            Console.WriteLine(pero.PredstaviSe());
            Console.WriteLine();

            korisnici.Add(miro);
            korisnici.Add(marko);
            korisnici.Add(ivan);
            korisnici.Add(pero);

            Console.WriteLine("\nPopis korisnika:");
            foreach(Korisnik k in korisnici)
            {
                Console.WriteLine(k.PredstaviSe());
            }


            Console.WriteLine();
        }
    }
}
