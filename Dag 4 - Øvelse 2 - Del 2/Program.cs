using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Når nu et array ikke kan udvides med flere pladser, hvordan gør man så?
//Find ud af hvad man så gør.
//Hint: Kig på hvad der sker i erklæringen af et array --- Hvad?

namespace Dag_4___Øvelse_2___Del_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bruger Array.Resize
            Console.WriteLine("Using Array.Resize\n");

            int[] myArray1 = new int[5];
            Console.WriteLine($"The size of myArray1 is {myArray1.Length}");

            Console.WriteLine("Please input the new size/length of the array");

            int newSize1;
            bool validInput1 = false;

            while (!validInput1)
            {
                if (int.TryParse(Console.ReadLine(), out newSize1))
                {
                    Array.Resize(ref myArray1, newSize1);
                    Console.WriteLine($"The new size of the array is now: {myArray1.Length}");

                    validInput1 = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            //Bruger Array.Copy, til at kopiere dataen fra arrayen over i en ny array af en anden størrelse
            Console.WriteLine("Using Array.Copy\n");

            int[] myArray2 = new int[5];

            Console.WriteLine($"The size of myArray2 is {myArray2.Length}");

            Console.WriteLine("Please input the new size/length of the array");

            int newSize2;
            bool validInput2 = false;

            while (!validInput2)
            {
                if (int.TryParse(Console.ReadLine(), out newSize2))
                {
                    int[] temp = new int[newSize2]; //Laver en ny midlertidig array
                    Array.Copy(myArray2, temp, myArray2.Length); //Kopiere data fra myArray2 til temp

                    myArray2 = temp; //Overskriver myArray2 (Data & længde) med temp
                    
                    Console.WriteLine($"The new size of the array is now: {myArray2.Length}");

                    validInput2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            

            //Pauses the program
            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }
    }
}
