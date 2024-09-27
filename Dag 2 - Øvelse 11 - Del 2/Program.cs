using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lav et quizprogram, som stiller brugeren 10 spørgsmål. Hvis brugeren svarer forkert mister han point,
//hvis der svares rigtigt tildeles han et point. Til sidst skrives brugernavn og scoren ud til konsollen
//Hint brug while til at stille spørgsmålet igen og if til at teste om brugeren har svaret korrekt

namespace Dag_2___Øvelse_11___Del_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this short quiz!\n" +
                "I will ask you a total of 10 questions, you will answer to the best of your abilities.\n" +
                "If you get a question right i will give you a point, if not i will take a point.\n" +
                "\nFirst however, what is your name?");

            string username = Console.ReadLine();

            Console.WriteLine($"{username} what a splendid name! Now, on to the questions...");

            for (int i = 0; i <= 10; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("First question:\n" +
                            "");

                        string answer1 = Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
