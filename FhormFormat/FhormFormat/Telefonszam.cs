using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FhormFormat
{
    class Telefonszam
    {
        public int[] telefon { get; set; }

            public Telefonszam(int[] telefon)
        {
            this.telefon = telefon;

        }
        public string TelefonszamSzamito()
        {
            string kimeno = "";


            for (int i = 0; i < this.telefon.Length; i++)
            {
                kimeno = String.Concat(kimeno,telefon[i]);
            }
            kimeno = String.Concat("(", kimeno.Substring(0, 3), ") ", kimeno.Substring(3, 3), "-", kimeno.Substring(6));


            return kimeno;






        }






    }
}
