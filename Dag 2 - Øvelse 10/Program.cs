using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 70 "Tæl fra 1 til 10 på 3 måder. Øvelsen skal laves på 3 måder med en while, do..while og en for-løkke"

namespace Dag_2___Øvelse_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For-loop:"); //For loop som tjekker om a er mindre end eller lig med 10, printer værdien og derefter forøger dens værdi
            for (int a = 0; a <= 10; a++)
            {
                Console.WriteLine($"a er {a}\n");
            }
            


            Console.WriteLine("While-loop:"); //While loop, som tjekker om b er mindre end eller lig med 10, printer den nuværende værdi og forøger med 1
            int b = 0;
            while (b <= 10)
            {
                Console.WriteLine($"b er {b}\n");
                b++;
            }
            


            Console.WriteLine("Do..While-loop:"); //Do..While-loop som printer værdien af c, forøger værdien og tjekker om den er under eller lig med 10
            int c = 0;
            do
            {
                Console.WriteLine($"c er {c}\n");
                c++;
            } while (c <= 10);
            


            //Pauser programmet
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
    }
}
