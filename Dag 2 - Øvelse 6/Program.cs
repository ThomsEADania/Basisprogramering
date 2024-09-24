using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 43

namespace Dag_2___Øvelse_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = string.Empty;
            string password = string.Empty;
            string pressAnyKey = "Press any key to close the program...";

            Console.WriteLine("Select your language/Vælg dit sprog: \n1. English \n2. Dansk");
            int language = int.Parse(Console.ReadLine());

            if (language == 1)
            {
                //Engelsk version
                Console.WriteLine("Please enter your age");
                int age = int.Parse(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("Creating new user account:");
                    
                    Console.WriteLine("Please enter your username");
                    username = Console.ReadLine();

                    Console.WriteLine("Please enter your password");
                    password = Console.ReadLine();
                    
                    Console.WriteLine("User account created!");
                }
                else
                {
                    Console.WriteLine("You are not old enough!");
                    
                    Console.WriteLine(pressAnyKey);
                    Console.ReadKey();
                }
                Console.WriteLine("Login:");
                
                Console.WriteLine("Please enter your username");
                string inUsername = Console.ReadLine();

                Console.WriteLine("Please enter your password");
                string inPassword = Console.ReadLine();

                if (inUsername == username && inPassword == password)
                {
                    Console.WriteLine($"Welcome {username}!");

                    Console.WriteLine(pressAnyKey);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid username or password");

                    Console.WriteLine(pressAnyKey);
                    Console.ReadKey();
                }
            }
            else if (language == 2)
            {
                //Dansk version
                Console.WriteLine("Indtast din alder");
                int age = int.Parse(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("Opretter ny bruger konto:");

                    Console.WriteLine("Indtast dit brugernavn");
                    username = Console.ReadLine();

                    Console.WriteLine("Indtast dit password");
                    password = Console.ReadLine();

                    Console.WriteLine("Bruger konto oprettet!");
                }
                else
                {
                    Console.WriteLine("Du er ikke gammel nok!");

                    Console.WriteLine(pressAnyKey);
                    Console.ReadKey();
                }
                Console.WriteLine("Login:");

                Console.WriteLine("Indtast dit brugernavn");
                string inUsername = Console.ReadLine();

                Console.WriteLine("Indtast dit password");
                string inPassword = Console.ReadLine();

                if (inUsername == username && inPassword == password)
                {
                    Console.WriteLine($"Velkommen {username}!");

                    Console.WriteLine(pressAnyKey);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ugyldigt brugernavn eller password");

                    Console.WriteLine(pressAnyKey);
                    Console.ReadKey();
                }
            }
            else
            {
                //Håndtere hvis brugeren skriver noget andet end 1 (Engelsk) eller 2 (Dansk)
                Console.WriteLine("Invalid input");

                Console.WriteLine(pressAnyKey);
                Console.ReadKey();
            }
        }
    }
}