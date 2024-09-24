using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Slide 51 "Lav en characterbuilder af switch cases, vælg faction, race & class, skriv et karakter navn.
//Når alt er valgt, skrives der en besked hvor alt det valgte info indgår fx Hello ”Name” you are a Horde, Orc Warrior."

namespace Dag_2___Øvelse_8
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Please choose a faction:" + //Valg af faction
                "\n - Alliance" +
                "\n - Horde");
            string faction = Console.ReadLine();

            string race = string.Empty; //Valg af race (Tilgængelige racer afhænger af faction)
            switch (faction)
            {
                case "Alliance":
                    Console.WriteLine("Please choose a race:" +
                        "\n - Human" +
                        "\n - Dwarf" +
                        "\n - Night Elf" +
                        "\n - Gnome" +
                        "\n - Draenai");
                    race = Console.ReadLine();
                    break;

                case "Horde":
                    Console.WriteLine("Please choose a race:" +
                        "\n - Orc" +
                        "\n - Undead" +
                        "\n - Tauren" +
                        "\n - Troll" +
                        "\n - Blood Elf");
                    race = Console.ReadLine();
                    break;
            }

            Console.WriteLine("Please choose a class:" + //Valg af class (Variabel navngivet "clas" for at undgå problemer hvis den hed "class"
                        "\n - Warrior" +
                        "\n - Paladin" +
                        "\n - Hunter" +
                        "\n - Rogue" +
                        "\n - Priest" +
                        "\n - Shaman" +
                        "\n - Mage" +
                        "\n - Warlock" +
                        "\n - Druid");
            string clas = Console.ReadLine();

            Console.WriteLine("Please enter your character's name:"); //Valg af karakternavn
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, you are a {faction}, {race} {clas}."); //Opsummering af karakter



            //Pauser programmet
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();
        }
    }
}
