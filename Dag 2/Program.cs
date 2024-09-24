using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Slide 14
            int n = 6;
            
            bool result1 = n == 5;
            bool result2 = n >= 5;
            bool result3 = n != 5;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
