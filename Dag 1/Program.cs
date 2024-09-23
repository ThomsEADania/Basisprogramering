using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //Øvelse 1 - Slide 55 (grøn)

            Console.WriteLine("Hello World!");



            //Øvelse 2 - Slide 56 (gul)

            Console.WriteLine("This is the WriteLine method");

            Console.Write("And this is the Write method (Doesn't add a new line)");



            //Øvelse 3 - Slide 57 (rød)

            //Skipped for now ================================================================================
            //1. Leg med konsol farverne hva. Console.Color (Findes ikke?) & Console.BackgroundColor
            //2. Find ud af hvordan man får konsol programmet til at sige en bip lyd



            //Øvelse 4 - Slide 78 (grøn)
            //Del 1 - "Lav ”hello world” øvelsen om således at der bruges variabler"

            string helloWorld = ("Hello World!");
            Console.WriteLine(helloWorld);

            //Del 2 - "Lav et program der skriver indtastet tekst ud til skærmen"

            //Ikke nødvendig men gør det mere klart hvad brugeren skal
            string message = "Please enter your name";
            Console.WriteLine(message);

            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}");



            //Øvelse 5 - Slide 79 (gul) - "Find ud af hvad forskellen er på ReadLine og ReadKey"

            //ReadLine venter på at brugeren trykker Enter og "læser" alt den tekst man har indtastet og giver en string, bruges f.eks. til at lade brugeren indtaste deres navn

            //ReadKey "læser" input med det samme en tast trykkes og giver en "ConsoleKeyInfo" som indeholder data om hvilken tast blev trykket
            //& om der er nogle "modifier" keys som CTRL, SHIFT eller ALT



            //Øvelse 6 - Slide 80 (rød) - "Lav et program der skriver indtastet tekst ud til skærmen, men uden brug af variabler"

            Console.WriteLine(Console.ReadLine());



            //Øvelse 7 - Slide 86 (grøn) - "Lav et mailing label program, som spørger efter og printer: adresse, by, land, navn"

            //Øvelse 8 - Slide 87 (gul) - "Udvid programmet med telefonnummer, postnummer, alder etc."

            //Øvelse 9 - Slide 88 (rød) - "Valider input, Dvs. tjek at det korrekt bliver indtastet, f.eks. om en e-mail har det korrekte format, osv."



            //Øvelse 10 - Slide 96 (grøn)

            //Øvelse 11 - Slide 97 (gul)

            //Øvelse 12 - Slide 98 (rød)
            


            //Waits for user input before continuing (closing the program, as there isn't any more code)
            Console.ReadLine();
        }
    }
}
