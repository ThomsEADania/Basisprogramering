using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array af ints - Lav et array bestående af værdierne : 12,33,532,145,1,4565,1 (Behøver ikke være de værdier)
//1. Skriv værdien af det femte element ud til skærmen
//2. Ændre værdien af det tredje element til 36562 (Behøver ikke være den værdi)
//3. Skriv alle ints ud til skærmen. Både via for og foreach

namespace Dag_4___Øvelse_1___Del_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            //1. Skriv værdien af det femte element ud til skærmen
            Console.WriteLine("The fifth element in myArray is: " + myArray[4]);

            //2. Ændre værdien af det tredje element til 36562 (Behøver ikke være den værdi)
            Console.WriteLine($"\nThe third element in myArray is currently: " + myArray[2]);

            Console.WriteLine("\nPlease input an integer you wish to change the element to");
            
            myArray[2] = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nThe third element in myArray is now: " + myArray[2]);

            //3. Skriv alle ints ud til skærmen. Både via for og foreach
            Console.WriteLine("\nFor-loop");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nForEach-loop");

            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }



            //Pauses the program
            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }
    }
}
