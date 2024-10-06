using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_program___Dag_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[25]
            {
                "apple",
                "tiger",
                "chair",
                "rocket",
                "cloud",
                "window",
                "bridge",
                "garden",
                "banana",
                "pirate",
                "pencil",
                "flower",
                "island",
                "puzzle",
                "dragon",
                "helmet",
                "ladder",
                "circle",
                "bottle",
                "candle",
                "forest",
                "giraffe",
                "pyramid",
                "shadow",
                "dolphin"
            };
            
            Random rand = new Random();

            bool resetGame = true;

            while (resetGame)
            {
                byte wordIndex = Convert.ToByte(rand.Next(25)); //Generates random number from 0 to 24 (25 is the exclusive upper limit)
                string secretWord = words[wordIndex]; //Picks word from words array based on random number wordIndex

                bool[] charGuessed = new bool[secretWord.Length]; //Creates boolean array with length equal to amount of characters in secretWord
                byte guessesLeft = 10; //Sets amount of guesses
                
                StringBuilder wrongChars = new StringBuilder(); //Creates a stringbuilder to save all the wrong guesses
                
                bool gameRunning = true;

                while (gameRunning)
                {
                    #region UI
                    Console.Clear(); //Clears console before each "round"

                    for (byte i = 0; i < secretWord.Length; i++) //Runs the same amount of times as amount of characters in secretWord
                    {
                        if (charGuessed[i] == true) //Displays char in secretWord at index i if the char has been guessed
                        {
                            Console.Write(secretWord[i]);
                        }
                        else //Displays _ if the char in secretWord at index i has not been guessed
                        {
                            Console.Write('_');
                        }
                    }

                    Console.WriteLine($"   Guesses left: {guessesLeft}" + //Displays number of guesses left
                        $"\nIncorrect guessed characters: {wrongChars}\n"); //Displays incorrect guessed characters
                    #endregion

                    #region Guessing
                    Console.WriteLine("Enter a character to guess");

                    char playerGuess;
                    bool guessPrompt = true;

                    while(guessPrompt == true) //Keeps prompting for guess until a valid input is entered
                    {
                        if (char.TryParse(Console.ReadLine(), out playerGuess)) //Take player input and checks if it can be parsed to a char
                        {
                            #region Checking guess
                            guessPrompt = false; //If input can be parsed, set guessPrompt to false so it stops prompting for input

                            bool correctChar = secretWord.Contains(playerGuess); //Checks if secretWord contains the guessed char (playerGuess)

                            if (correctChar)
                            {
                                for (byte i = 0; i < secretWord.Length; i++) //Runs for each character of secretWord
                                {
                                    if (!charGuessed[i] == true) //Skips characters in the secretWord if they have already been guessed correctly
                                    {
                                        if (playerGuess == secretWord[i]) //Checks if guessed char matches char at index i in string secretWord
                                        {
                                            charGuessed[i] = true; //Set value in boolean array charGuess at index i to true
                                        }
                                    }
                                }
                            }
                            else //If secretWord does not contain guessed char
                            {
                                guessesLeft--; //Decreases number of guesses left

                                wrongChars.Append(playerGuess + " "); //Adds guessed char to wrongChars stringbuilder with a space
                            }
                            #endregion
                        }
                        else //If input can´t be parsed, displays error message
                        {
                            Console.WriteLine("Invalid input, try again");
                        }
                    }
                    #endregion

                    #region Checking if game is won
                    bool secretWordGuessed = true;

                    foreach (bool value in charGuessed) //Checks if all values in charGuessed bool array is true, if not the game continues
                    {
                        if (!value)
                        {
                            secretWordGuessed = false;
                            break;
                        }
                    }
                    #endregion

                    #region Win/Lose message
                    if (secretWordGuessed) //If the word was guessed
                    {
                        Console.WriteLine($"\nYou guessed the word! it was: {secretWord}");

                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break;
                    }
                    else if (guessesLeft <= 0) //If player runs out of guesses (didn´t guess the word)
                    {
                        Console.WriteLine($"\nYou lost, the secret word was: {secretWord}");

                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break;
                    }
                    #endregion
                }

                #region Play again/Exit prompt
                Console.Clear(); //Clears console so it is only the prompt on screen

                bool exitPrompt = true;

                while (exitPrompt) //Keeps prompting until a valid input is given
                {
                    Console.WriteLine("Do you want to play again or exit?");
                    
                    string answer = Console.ReadLine().ToLower();
                    
                    if (answer == "play again" || answer == "play")
                    {
                        exitPrompt = false;  
                        resetGame = true;
                    }
                    else if (answer == "exit")
                    {
                        exitPrompt = false;
                        resetGame = false;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Invalid input, try again\n");
                    }
                }
                #endregion
            }
        }
    }
}
