using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////Slide 53 - Del 4 "Lav funktioner til at udregne følgende:
//Alle funktionerne skal returnere resultatet af udregningen

namespace Dag_3___Øvelse_2___Del_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers");
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
        static int Add(int a, int b) //Lægge 2 tal sammen
        {
            return a + b;
        }
        static int Subtract(int a, int b) // Trække 2 tal fra hinanden
        {
            return a - b;
        }
        static int Multiply(int a, int b) //Gange 2 tal sammen
        {
            return a * b;
        }
        static int Divide(int a, int b) //Dividere 2 tal
        {
            return a / b;
        }
    }
}
