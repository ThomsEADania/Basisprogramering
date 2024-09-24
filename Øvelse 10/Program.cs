using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 96 - "Lav en applikation, som kan udføre en beregninger på 2 indtastede tal dvs. * + / - etc.
//Beregningerne samt resultaterne skal præsenteres brugeren"

namespace Øvelse_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will ask you to choose 2 numbers and use them in a list of mathematical operations\n");
            
            Console.WriteLine("Please enter the first number, a");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number, b");
            float num2 = float.Parse(Console.ReadLine());

            float result1 = num1 + num2;
            float result2 = num1 - num2;
            float result3 = num1 * num2;
            float result4 = num1 / num2;

            Console.WriteLine($"a + b = {num1} + {num2} = {result1}");
            Console.WriteLine($"a - b = {num1} + {num2} = {result2}");
            Console.WriteLine($"a * b = {num1} + {num2} = {result3}");
            Console.WriteLine($"a / b = {num1} + {num2} = {result4}");

            //Pauses the program
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();
        }
    }
}
