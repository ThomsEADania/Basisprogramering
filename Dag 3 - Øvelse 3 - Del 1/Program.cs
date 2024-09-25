using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 63
//Funktionerne fra tidligere øvelser skal kommenteres.
//Kontroller at intellisense viser jeres kommentarer, når I prøver at kalde jeres kode.

namespace Dag_3___Øvelse_3___Del_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers"); //Taget fra Øvelse 2 - Del 4
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition\n" + $"{num1} + {num2} = " + Add(num1, num2) + "\n");

            Console.WriteLine("Subtraction\n" + $"{num1} - {num2} = " + Subtract(num1, num2) + "\n");

            Console.WriteLine("Multiplication\n" + $"{num1} * {num2} = " + Multiply(num1, num2) + "\n");

            Console.WriteLine("Division\n" + $"{num1} / {num2} = " + Divide(num1, num2) + "\n");

            //Pauses the program
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
        /// <summary>
        /// Adds 2 integers together
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns>Result of: a + b</returns>
        static int Add(int a, int b) //Lægge 2 tal sammen
        {
            return a + b;
        }
        /// <summary>
        /// Subtracts the first integer from the second
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns>Result of: a - b</returns>
        static int Subtract(int a, int b) // Trække 2 tal fra hinanden
        {
            return a - b;
        }
        /// <summary>
        /// Multiplies the first integer with the second
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">First integer</param>
        /// <returns>Result of: a * b</returns>
        static int Multiply(int a, int b) //Gange 2 tal sammen
        {
            return a * b;
        }
        /// <summary>
        /// Divides the first integer with the second
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">First integer</param>
        /// <returns>Result of: a / b</returns>
        static int Divide(int a, int b) //Dividere 2 tal
        {
            return a / b;
        }
    }
}
