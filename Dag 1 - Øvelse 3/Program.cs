using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Øvelse_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 3 - Slide 57 (rød)

            //Del 1 - Leg med konsol farverne hva. Console.BackgroundColor & Console.ForegroundColor

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("The background is now blue and the text is white");



            //Del 2 - Find ud af hvordan man får konsol programmet til at sige en bip lyd

            Console.WriteLine("Press any key to play a beep");
            Console.ReadKey();
            Console.Beep();

            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }
    }
}
