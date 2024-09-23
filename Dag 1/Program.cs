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
            //Console.WriteLine adds a newline/line break after printing the string
            Console.WriteLine("Hello World!");

            //Console.Write does not add a newline/line break after printing the string
            Console.Write("Write");

            //Added for clarity, only prints string, does not add any functionality beyond that
            Console.WriteLine("Press any key to close the program...");
            
            //Waits for user input before continuing (closing the program, as there isn't any more code)
            Console.ReadLine();
        }
    }
}
