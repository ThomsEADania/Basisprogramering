using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Obligatorisk_Opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guess-a-number game, please state your name:");

            //Reads user input and saves it to "username" variable
            string username = Console.ReadLine();

            Console.WriteLine($"Very good {username}! Now, guess a number between 0 - 100.");

            //Generates a random number between 0 & 100
            Random rnd = new Random();
            int num = rnd.Next(0,101);

            int guess = int.Parse(Console.ReadLine());

            int distance;

            //Checks if the guess is correct or not and calculates how far off the guess was
            if (guess == num)
            {
                Console.WriteLine($"Excellent! You got it {username}! The number was {num}.");
            }
            else if (guess > num)
            {
                distance = guess - num;
                Console.WriteLine($"Not quite {username}, the number was {num}, you were only {distance} off.");
            }
            else
            {
                distance = num - guess;
                Console.WriteLine($"Not quite {username}, the number was {num}, you were only {distance} off.");
            }



            //Pauses the program
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();
        }
    }
}
