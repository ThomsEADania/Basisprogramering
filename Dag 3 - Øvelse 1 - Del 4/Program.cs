using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 23
//Del 4 "Lav en enum til at definere en retning:
//1. Lav enum og lav en variabel der bruger denne enum som datatype.
//2. Skriv variablens værdi ud til skærmen.
//3. Lav et program, der spørger hvilken retning spilleren vil bevæge sig i.
// -> Når spilleren vælger en retning skal variablen ændres til den valgte retning.
// -> F.eks.Tast 1 for north, 2 for south, 3 for east, 4 for west.
//4. Variablens nye værdi skrives ud til skærmen."

namespace Dag_3___Øvelse_1___Del_4
{
    enum direction: byte
    {
        North = 1, South = 2, East = 3, West = 4, Exit=5
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            direction myDirection = direction.North;

            while (myDirection != direction.Exit)
            {
                Console.WriteLine("Venture forth traveller! Choose a direction to move:" +
                    "\n 1. North" +
                    "\n 2. South" +
                    "\n 3. East" +
                    "\n 4. West" +
                    "\n 5. Exit");

                myDirection = (direction)Enum.Parse(typeof(direction), Console.ReadLine());

                Console.Clear();

                Console.WriteLine($"You went {myDirection}.\n");
            }
        }
    }
}
