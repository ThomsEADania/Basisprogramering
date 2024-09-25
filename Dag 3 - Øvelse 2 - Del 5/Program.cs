using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////Slide 53 - Del 5 "Lav en funktion der kan løse følgende matematisk udtryk og returnere resultatet:
//(x + b * 10) / y"

namespace Dag_3___Øvelse_2___Del_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three integers to use in this function:\n" +
                "(x + b * 10) / y");

            Console.WriteLine("\nEnter your value for x");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter your value for b");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter your value for y");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n({num1} + {num2} * 10) / {num3} = " + Fx(num1, num2, num3));



            //Pauses the program
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
        static float Fx(float x, float b, float y)
        {
            return (x + b * 10) / y;
        }
    }
}
