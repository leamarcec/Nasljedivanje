﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi
{
    public class Profesor:Korisnik
    {
        private string predmeti;

        public void ZadajPredmete(string predmeti)
        {
            this.predmeti = predmeti;
        }
        public override string PredstaviSe()
        {
            return String.Format("Ja sam profesor {0} zaporka mi je {1} i predajem predmete {2}",
                korisnickoIme, zaporka,predmeti);

        }
    }
}
