using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = string.Empty;
            string password = string.Empty;
            
            Console.WriteLine("Login:");

            Console.WriteLine("Please enter your username");
            string inUsername = Console.ReadLine();

            Console.WriteLine("Please enter your password");
            string inPassword = Console.ReadLine();

            switch (inUsername)
            {
                case "Bob":
                    username = "Bob";
                    password = "1";
                    break;

                case "Wade":
                    username = "Wade";
                    password = "2";
                    break;

                case "Mark":
                    username = "Mark";
                    password = "3";
                    break;

                case "Robert":
                    username = "Robert";
                    password = "4";
                    break;

                case "Steve":
                    username = "Steve";
                    password = "5";
                    break;

                case "Tyler":
                    username = "Tyler";
                    password = "6";
                    break;

                case "John":
                    username = "John";
                    password = "7";
                    break;

                case "Dennis":
                    username = "Dennis";
                    password = "8";
                    break;

                case "Daniel":
                    username = "Daniel";
                    password = "9";
                    break;

                case "William":
                    username = "William";
                    password = "10";
                    break;

                default:
                    Console.WriteLine("Your account does not exist.");
                    break;

            }
            if (inUsername == username && inPassword == password)
            {
                Console.WriteLine($"Welcome {username}, you have succesfully logged in!");

                Console.WriteLine("\nPress any key to close the program...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nPress any key to close the program...");
                Console.ReadKey();
            }
        }
    }
}