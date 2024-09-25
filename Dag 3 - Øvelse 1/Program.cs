using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 23

namespace Dag_3___Øvelse_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Del 1 "Parse noget input fra en Readline() til en int værdi fx indtast 10 og gem det i, int myInput;"
            Console.WriteLine("Input an integer:");
            
            int myInput;
            myInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"myInput is {myInput}\n");



            //Del 2 "Prøv at caste en int værdi som er højre end 255 og skriv resultatet ud til konsollen. Tilføj en checked block til jeres overflow cast"
            byte myByte;

            checked //Hvis checked-blokken ikke er her, kommer der et overflow, men ikke en fejl, checked laver en exception hvis der kommer et overflow 
            {
                myByte = (byte)myInput;
            }

            Console.WriteLine($"myByte is {myByte}\n");



            //Del 3 "Prøv at caste en float værdi 2322.223 til en int og skriv resultatet ud til konsollen"
            float myFloat = 2322.223F;
            int myInt;

            myInt = (int)myFloat;

            Console.WriteLine($"Converting myFloat ({myFloat}) to myInt: \nmyInt is now {myInt}\n");

            

            //Pauser programmet
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
    }
}
