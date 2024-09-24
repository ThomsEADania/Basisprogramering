using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 42

namespace Dag_2___Øvelse_5
{
    internal class Program
    {
        static string username = "Thoms";
        static string password = "password";
        static string pressAnyKey = "Press any key to close the program...";

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your language (Dansk/English)");

            string lang = Console.ReadLine();

            if (lang == "English")
            {
                Console.WriteLine("Please enter your age");

                int age = Convert.ToInt16(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("Please enter your username");

                    if (Console.ReadLine() == username)
                    {
                        Console.WriteLine("Please enter your password");

                        if (Console.ReadLine() == password)
                        {
                            Console.WriteLine("Welcome Thoms");

                            Console.WriteLine(pressAnyKey);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid password");

                            Console.WriteLine(pressAnyKey);
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid username");

                        Console.WriteLine(pressAnyKey);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("You are not old enough to use this program");

                    Console.WriteLine(pressAnyKey);
                    Console.ReadKey();
                }
            }
            else if (lang == "Dansk")
            {
                Console.WriteLine("Indtast din alder");

                int age = Convert.ToInt16(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("Indtast dit username");

                    if (Console.ReadLine() == username)
                    {
                        Console.WriteLine("Indtast dit password");

                        if (Console.ReadLine() == password)
                        {
                            Console.WriteLine("Velkommen Thoms");

                            Console.WriteLine(pressAnyKey);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt password");

                            Console.WriteLine(pressAnyKey);
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt username");

                        Console.WriteLine(pressAnyKey);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Du er ikke gammel nok til at bruge dette program");

                    Console.WriteLine(pressAnyKey);
                    Console.ReadKey();
                }
            }
        }
    }
}