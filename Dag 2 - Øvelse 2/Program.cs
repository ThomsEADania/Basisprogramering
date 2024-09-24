using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Slide 15
            int n = 6;

            bool result1 = n >= 5 && n < 10;
            bool result2 = !(n >= 5 && n < 10);
            bool result3 = n < 5 || n >= 10;
            bool result4 = n > 5 || n >= 10;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.ReadLine();
        }
    }
}
