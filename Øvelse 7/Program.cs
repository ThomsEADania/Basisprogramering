using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Øvelse 7 - Slide 86 (grøn) - "Lav et mailing label program, som spørger efter og printer: adresse, by, land, navn"

namespace Øvelse_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter the country you live in:");
            string country = Console.ReadLine();

            Console.WriteLine("Please enter the city you live in:");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter your street adress:");
            string address = Console.ReadLine();

            Console.WriteLine($"Here's your mailing label:\n{name}\n{address}, {city}, {country}");

            Console.ReadKey();

        }
    }
}
