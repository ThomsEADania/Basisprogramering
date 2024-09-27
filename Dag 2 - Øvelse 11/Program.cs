using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 71 - Simulation af det at tage skade i et spil
//Man skal starte med 100 i health. Brugeren vil blive bedt om at indtaste x damage for at give skade. Health reduceres
//med den indtastede værdi, indtil der er 0 health tilbage
//Når der er 0 i health skrives hvor mange hits der skulle til for at komme til 0 i health

namespace Dag_2___Øvelse_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 100; //Opretter nødvendige variables
            int damage = 0;
            int numHits = 0;

            while (playerHealth > 0) //Kører så længe playerHealth er mere end 0, når den når 0, kører den videre
            {
                Console.WriteLine($"Your health is: {playerHealth}\n" + //Viser hvor meget liv spilleren har tilbage
                    "Input a number to take that much damage");

                damage = int.Parse(Console.ReadLine()); //Læser hvor meget skade spilleren giver (sig selv)
                
                playerHealth -= damage; //Trækker damage fra playerHealth og gemmer dens nye værdi
                numHits++; //Tæller op hvor mange gange loopet er kørt (hvor mange hits man har lavet)
            }

            Console.WriteLine($"You have taken a fatal amount of damage over {numHits} hits"); //Opsummere hvor mange hits det
                                                                                               //tog at nå playerHealth < 0
                    
                    
                    
            //Pauses the program
            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }
    }
}
