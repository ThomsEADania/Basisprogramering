using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Udvid forrige øvelse med muligheden for at brugeren af programmet kan ændre på arrayet
//Spørg brugen hvilken placering i array han/hun vil ændre
//Ændre værdien på pladsen i array’et til det brugeren indtaster
//Arrayet skal skrives ud til konsollen hver gang der er foretaget en ændring

namespace Dag_4___Øvelse_2___Del_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Clear();

                Console.WriteLine("Here's the array:");
                foreach (int number in myArray)
                {
                    Console.WriteLine(number);
                }
                
                Console.WriteLine("\nPlease input an integer corresponding to the array element you wish to change (1-10)");
                int arrayPos = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("\nPlease input an integer you wish to change the array element to");
                int newNumber = int.Parse(Console.ReadLine());

                myArray[arrayPos] = newNumber;
            }
        }
    }
}
