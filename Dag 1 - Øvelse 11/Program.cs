using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Øvelse_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will ask you to choose 2 numbers and use them in a list of mathematical and compound assignment operations\n");

            Console.WriteLine("Please enter the first number, a");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number, b");
            float num2 = float.Parse(Console.ReadLine());

            //Udregning
            float result1 = num1 + num2;
            float result2 = num1 - num2;
            float result3 = num1 * num2;
            float result4 = num1 / num2;
            
            //Almindelige matematiske operationer
            Console.WriteLine("\nMathematical operations:");
            Console.WriteLine($"a + b = {num1} + {num2} = {result1}");
            Console.WriteLine($"a - b = {num1} - {num2} = {result2}");
            Console.WriteLine($"a * b = {num1} * {num2} = {result3}");
            Console.WriteLine($"a / b = {num1} / {num2} = {result4}");

            float originalnum1 = num1; //Gemmer den originale værdi af num1 da den ellers vil blive ændret når man bruger tildelings operatorer (+=, -=, osv.)

            //Udregning
            float result5 = num1 += num2;
            num1 = originalnum1; //"Nulstiller" num1 til den originale værdi

            float result6 = num1 -= num2;
            num1 = originalnum1;

            float result7 = num1 *= num2;
            num1 = originalnum1;

            float result8 = num1 /= num2;
            num1 = originalnum1;

            //Tildelings operationer
            Console.WriteLine("\nCompound assignment operations:");
            Console.WriteLine($"a += b = {num1} += {num2} = {result5}");
            Console.WriteLine($"a -= b = {num1} -= {num2} = {result6}");
            Console.WriteLine($"a *= b = {num1} *= {num2} = {result7}");
            Console.WriteLine($"a /= b = {num1} /= {num2} = {result8}");



            //Pauses the program
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();
        }
    }
}
