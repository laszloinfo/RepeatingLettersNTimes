using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepatingLettersNTimes
{
    class Szoveg
    {

        static string Ismetel(string bemeno, int hanyszor)
        {
            string kimeno = "";

            if (bemeno.Length == 0)
            {
                return kimeno = "Üres stringel nem tudok dolgozni!";
            }
            else
            {
                for (int i = 0; i < bemeno.Length; i++)
                {
                    for (int j = 0; j < hanyszor; j++)
                    {
                        kimeno = String.Concat(kimeno, bemeno[i]);
                    }


                }
                return kimeno;
            }
          


    }
    }
}
