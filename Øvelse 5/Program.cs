using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 5 - Slide 79 (gul) - "Find ud af hvad forskellen er på ReadLine og ReadKey"

            Console.WriteLine("ReadLine venter på at brugeren trykker Enter og \"læser\" alt den tekst man har indtastet og giver en string.\n" +
                "Bruges f.eks. til at lade brugeren indtaste deres navn, eller anden tekststreng.");
            Console.WriteLine("Prøv det nu!");
            Console.ReadLine();

            //Tilføjer en ny tom linje for at hjælpe med læseligheden
            Console.WriteLine("\n");

            Console.WriteLine("ReadKey \"læser\" input med det samme en tast trykkes og giver en \"ConsoleKeyInfo\" som indeholder data om \n" + 
                "hvilken tast blev trykket & om der er nogle \"modifier\" keys som CTRL, SHIFT eller ALT\n" + 
                "Bruges f.eks. til specifikke key-inputs som WASD eller piletaster.");
            Console.WriteLine("Prøv det nu!");
            Console.ReadKey();



            //Pauser programmet
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
    }
}
