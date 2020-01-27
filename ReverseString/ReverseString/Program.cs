using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kérek egy mondatot");
            string bemeno = Console.ReadLine();

            Console.WriteLine($"A megfordított string:{Megfordit(bemeno)}");
            Szoveg szov = new Szoveg(bemeno);
            Console.WriteLine($"a megforditott szöveg: {szov.Megfordit()}");





            Console.ReadKey(true);
        }

        static string Megfordit(string bemeno)
        {
            string kimeno = "";
            for (int i = bemeno.Length -1; i >=  0; i--)
            {
                kimeno = String.Concat(kimeno, bemeno[i]);
            }
            return kimeno;
        }
}
}


