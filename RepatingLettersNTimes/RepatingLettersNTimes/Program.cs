using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepatingLettersNTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kérek egy stringet: ");
            string bemeno = Console.ReadLine();

            Console.WriteLine("Hányszor ismételje meg?: ");
            int hanyszor = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"az ismételt string: {Ismetel(bemeno,hanyszor)}");

            Szoveg sz = new Szoveg(bemeno);
            


            Console.ReadLine();

        }

        static string Ismetel (string bemeno,int hanyszor)
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
