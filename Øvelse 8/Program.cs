using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Øvelse 8 - Slide 87 (gul) - "Udvid programmet med telefonnummer, postnummer, alder etc."

namespace Øvelse_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your phone number");
            int phone = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the country you live in:");
            string country = Console.ReadLine();

            Console.WriteLine("Please enter the city you live in:");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter your city's postal code");
            int postal = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your street adress:");
            string address = Console.ReadLine();

            Console.WriteLine($"\nHere's your mailing label:\n{name}\n{address}, {city} {postal}, {country}\nPhone number: {phone}\nAge: {age}");

            //Pauses the program
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();
        }
    }
}
