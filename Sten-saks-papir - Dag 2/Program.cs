using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sten_saks_papir___Dag_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;

            while (keepPlaying == true) //The "== true" is technically unneccesary for function, but adds readability
            {
                string playerInput; 
                byte playerChoice = 0;
                bool choicePrompt = true;
                bool exit = false;

                while (choicePrompt == true)
                {
                    #region UI
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("You can at any point type \"exit\" or \"quit\" to close the program");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("What hand will you play:\n" +
                        "1. Rock\n" +
                        "2. Paper\n" +
                        "3. Scissors\n");
                    #endregion

                    #region Player input
                    playerInput = Console.ReadLine().ToLower(); //Take player input

                    switch (playerInput) //"Convert" player input to byte or exit the program
                    {
                        case string n when (n == "1" || n == "rock"):
                            playerChoice = 1;
                            choicePrompt = false;
                            break;

                        case string n when (n == "2" || n == "paper"):
                            playerChoice = 2;
                            choicePrompt = false;
                            break;

                        case string n when (n == "3" || n == "scissors"):
                            playerChoice = 3;
                            choicePrompt = false;
                            break;

                        case string n when (n == "exit" || n == "quit"):
                            choicePrompt = false;
                            keepPlaying = false;
                            exit = true;
                            break;

                        default: //Handles incorrect input
                            Console.Clear();

                            Console.WriteLine("Invalid input, try again\n");
                            
                            break;
                    }
                }

                if (exit == true) //Breaks gameloop if player entered exit/quit
                {
                    break;
                }
                #endregion

                //Computer choice - Assignment said to use switch, but it seems really unneccasary to me
                Random rand = new Random();
                byte npcChoice = Convert.ToByte(rand.Next(1, 4)); //Generates a byte between 1-3 (4 is max value and is excluded)
                    
                Console.Clear(); //Clears console to avoid cluttered interface

                #region Display result
                Console.WriteLine("Previous round result:"); //Technically not previous at this point in the code, but it is when playing the game

                if (playerChoice == npcChoice) //Would have used a switch for this part, but the assignment said to use an if statement ¯\_(ツ)_/¯
                {
                    Console.WriteLine("Ended in draw");
                }

                else if (playerChoice == 1 && npcChoice == 3) //Player wins with rock
                {
                    Console.WriteLine("Player won with rock against scissors");
                }

                else if (playerChoice == 2 && npcChoice == 1) //Player wins with paper
                {
                    Console.WriteLine("Player won with paper against rock");
                }

                else if (playerChoice == 3 && npcChoice == 2) //Player wins with scissors
                {
                    Console.WriteLine("Player won with scissors against paper");
                }

                else if (playerChoice == 1 && npcChoice == 2) //Player loses with rock
                {
                    Console.WriteLine("Player lost with rock agaisnt paper");
                }

                else if (playerChoice == 2 && npcChoice == 3) //Player loses with paper
                {
                    Console.WriteLine("Player lost with paper against scissors");
                }

                else if (playerChoice == 3 && npcChoice == 1) //Player loses with scissors
                {
                    Console.WriteLine("Player lost with scissors against rock");
                }

                Console.WriteLine(); //Empty line for readability in-game
                #endregion
            }
        }
    }
}
