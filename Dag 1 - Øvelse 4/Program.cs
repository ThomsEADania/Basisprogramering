using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Øvelse_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 4 - Slide 78 (grøn)

            //Del 1 - "Lav ”hello world” øvelsen om således at der bruges variabler"

            string helloWorld = ("Hello World!");
            Console.WriteLine(helloWorld);



            //Del 2 - "Lav et program der skriver indtastet tekst ud til skærmen"

            //Ikke nødvendig men gør det mere klart hvad brugeren skal
            Console.WriteLine("Please enter your name");

            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}");



            //Pauser programmet
            Console.ReadKey();
        }
    }
}
