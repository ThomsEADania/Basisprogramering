using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 53

namespace Dag_3___Øvelse_2_del_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aloha(); //Del 1

            Text("This is some text :)"); //Del 2

            int myNumber = BigNumber(); //Del 3
            Console.WriteLine(myNumber);

            //Pauses the program
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
        static void Aloha() //Del 1 "Lav en funktion der kan skrive en forud bestemt tekst ud til skærmen"
        {
            Console.WriteLine("Aloha");
        }
        static void Text(string text) //Del 2 "Lav en funktion der kan skrive en tekst der med sendes som parameter ud til skærmen"
        {
            Console.WriteLine(text);
        }
        static int BigNumber() //Del 3 "Lav en funktion der kan returnere en værdi. Gem resultatet i en variabel og skriv den her efter ud til skærmen."
        {
            return 100;
        }
    }
}
