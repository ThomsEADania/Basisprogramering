using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_menu_system
{
    enum gameChoice: byte
    {
        Menu = 0,
        Game1 = 1,
        Game2 = 2,
        Game3 =3,
        Game4 =4
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (exit != true)
            {
                Console.WriteLine("This is the menu" +
                    "\nPlease choose what game you want to play:" +
                    "\n1. Game1" +
                    "\n1. Game2" +
                    "\n1. Game3" +
                    "\n1. Game4");
                
                Console.ReadLine();

            }
        }
        static void Game1();
    }
}
