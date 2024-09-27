using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_menu_system
{
    enum gameSelect: byte
    {
        menu = 0,
        game1 = 1,
        game2 = 2,
        game3 = 3,
        game4 = 4,
        exit = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            gameSelect gameState = gameSelect.menu;

            while (gameState != gameSelect.exit)
            {
                Console.Clear();

                Console.WriteLine("Classic games launcher:" +
                    "\nPlease choose what game you want to play:" +
                    "\n1. Game1" +
                    "\n2. Game2" +
                    "\n3. Game3" +
                    "\n4. Game4" +
                    "\n5. Exit");

                if (Enum.TryParse(Console.ReadLine().ToLower(), out gameState))
                {
                    switch (gameState)
                    {
                        case gameSelect.game1:
                            Game1();
                            break;
                        
                        case gameSelect.game2:
                            Game2();
                            break;
                        
                        case gameSelect.game3:
                            Game3();
                            break;
                        
                        case gameSelect.game4:
                            Game4();
                            break;
                        
                        case gameSelect.exit:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            }
        }

        static void Game1()
        {
            bool returnToMenu = false;

            Console.Clear(); //Clears console so it is neat and ready to display the game

            while (returnToMenu != true) //Checks if it should return to the main menu
            {
                Console.WriteLine("Welcome to Game1");
                
                #region Game here please:
                
                #endregion

                bool menuPrompt = true; 

                while (menuPrompt == true) //When the game ends, prompts the player if they want to return to the menu
                                           //Will keep being displayed if an invalid input is entered
                {
                    Console.WriteLine("\nDo you want to return to main menu?");

                    string answer = Console.ReadLine().ToLower();

                    if (answer == "yes" || answer == "main menu")
                    {
                        menuPrompt = false;
                        returnToMenu = true;
                    }
                    else if (answer == "no" || answer == "play again")
                    {
                        menuPrompt = false;

                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
            }
        }
        static void Game2()
        {
            bool returnToMenu = false;

            Console.Clear(); //Clears console so it is neat and ready to display the game

            while (returnToMenu != true) //Checks if it should return to the main menu
            {
                Console.WriteLine("Welcome to Game2");

                #region Game here please:

                #endregion

                bool menuPrompt = true;

                while (menuPrompt == true) //When the game ends, prompts the player if they want to return to the menu
                                           //Will keep being displayed if an invalid input is entered
                {
                    Console.WriteLine("\nDo you want to return to main menu?");

                    string answer = Console.ReadLine().ToLower();

                    if (answer == "yes" || answer == "main menu")
                    {
                        menuPrompt = false;
                        returnToMenu = true;
                    }
                    else if (answer == "no" || answer == "play again")
                    {
                        menuPrompt = false;

                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Invalid input, try again.");
                    }
                }
            }
        }
        static void Game3()
        {
            bool returnToMenu = false;

            Console.Clear(); //Clears console so it is neat and ready to display the game

            while (returnToMenu != true) //Checks if it should return to the main menu
            {
                Console.WriteLine("Welcome to Game3");

                #region Game here please:

                #endregion

                bool menuPrompt = true;

                while (menuPrompt == true) //When the game ends, prompts the player if they want to return to the menu
                                           //Will keep being displayed if an invalid input is entered
                {
                    Console.WriteLine("\nDo you want to return to main menu?");

                    string answer = Console.ReadLine().ToLower();

                    if (answer == "yes" || answer == "main menu")
                    {
                        menuPrompt = false;
                        returnToMenu = true;
                    }
                    else if (answer == "no" || answer == "play again")
                    {
                        menuPrompt = false;

                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Invalid input, try again.");
                    }
                }
            }
        }
        static void Game4()
        {
            bool returnToMenu = false;

            Console.Clear(); //Clears console so it is neat and ready to display the game

            while (returnToMenu != true) //Checks if it should return to the main menu
            {
                Console.WriteLine("Welcome to Game4");

                #region Game here please:

                #endregion

                bool menuPrompt = true;

                while (menuPrompt == true) //When the game ends, prompts the player if they want to return to the menu
                                           //Will keep being displayed if an invalid input is entered
                {
                    Console.WriteLine("\nDo you want to return to main menu?");

                    string answer = Console.ReadLine().ToLower();

                    if (answer == "yes" || answer == "main menu")
                    {
                        menuPrompt = false;
                        returnToMenu = true;
                    }
                    else if (answer == "no" || answer == "play again")
                    {
                        menuPrompt = false;

                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Invalid input, try again.");
                    }
                }
            }
        }
    }
}
