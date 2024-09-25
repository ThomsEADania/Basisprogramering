using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 15

namespace Dag_2___Øvelse_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            bool result1 = n >= 5 && n < 10; //true, 6 er større end 5 og mindre end 10
            bool result2 = !(n >= 5 && n < 10); //false, da 6 er større end 5 og mindre end 10, modsat af ovenstående
            bool result3 = n < 5 || n >= 10; //false, 6 er hverken mindre end 5 eller større end eller lig med 10
            bool result4 = n > 5 || n >= 10; //true, 6 er større end 5 "n >= 10" har ingen indflydning i denne situation

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.ReadLine();
        }
    }
}
