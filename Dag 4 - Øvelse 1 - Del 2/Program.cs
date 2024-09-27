using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array af strings
//Lav et array bestående af navnene på mindst 10 af klassens studerende
//1. Skriv værdien af det femte element ud til skærmen
//2. Ændre værdien af det tredje element til Mario
//3. Skriv alle navnene ud til skærmen. Både via for og foreach

namespace Dag_4___Øvelse_1___Del_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[]
            {
                "Bob",
                "Wade",
                "Mark",
                "Tyler",
                "Ethan",
                "Dumbledore",
                "Snape",
                "Harry",
                "Ron",
                "Neville"
            };

            //1. Skriv værdien af det femte element ud til skærmen
            Console.WriteLine("The fifth element in myArray is: " + myArray[4]);

            //2. Ændre værdien af det tredje element til Mario (Behøver ikke være den string)
            Console.WriteLine($"\nThe third element in myArray is currently: " + myArray[2]);

            Console.WriteLine("\nPlease input a string you wish to change the element to");

            myArray[2] = Console.ReadLine();

            Console.WriteLine($"\nThe third element in myArray is now: " + myArray[2]);

            //3. Skriv alle ints ud til skærmen. Både via for og foreach
            Console.WriteLine("\nFor-loop");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nForEach-loop");

            foreach (string element in myArray)
            {
                Console.WriteLine(element);
            }



            //Pauses the program
            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }
    }
}
