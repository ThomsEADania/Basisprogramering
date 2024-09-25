using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Slide 64
//Gå ind på moodle og download filen Buggy_Code.
//Brug VS debuggeren til at steppe igennem koden for at finde og rette de 6 fejl.

namespace Dag_3___Øvelse_4
{
    internal class Program //Alt kode hentet fra Buggy_Code
    {
        //static int First = 12;
        //static string Message = "Hello World";
        //static int numbre = 1;
        //Fejl?

        static void Main(string[] args)
        {
            WriteNumberWithSwitchCase();

            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }

        /// <summary>
        /// Lægger to tal sammen og returnerer resultatet. Hvis man giver den 1,2 skal den returnere 3.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        static int AddNumbers(int first, int second)
        {
            return first + second; //Første parameter er kaldt "first" men når den forsøges at blive brugt i funktionen kaldes den
                                    //"First", det er case-sensitive
        }

        /// <summary>
        /// Skriver en besked ud til konsollen, skriver en beskedi konsollen, hvis man skriver Hello, skriver den Hello
        /// </summary>
        /// <param name="message">beskeden, som skrives ud</param>
        static void WriteMessage(string message)
        {
            Console.WriteLine(message); //Samme fejl som første funktion, parametren kaldes "message" men når den bruges kaldes
                                        //den for "Message"
        }

        /// <summary>
        /// Tæller til et tal, hvis der skrives 3 bør den skrive 1,2,3
        /// </summary>
        /// <param name="number">tallet der skal tælles til</param>
        static void CountToNumber(int number)
        {
            for (int i = 0; i < number; i++) //Stavefejl number/numbre
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Skriver beskeden med caps hvis bool parametret er true. Hvis der gives true og Hello, skal den skrive HELLO
        /// </summary>
        /// <param name="UseCaps">skal det skrives med caps</param>
        /// <param name="message">Beskeden der skal skrives</param>
        static void WriteMessageWithCaps(bool UseCaps, string message)
        {
            if (UseCaps == true) //Brugte = i stedet for ==, som prøver at "sætte" UseCaps værdi til true, i stedet
                                    //for at se om den er true
            {
                Console.WriteLine(message.ToUpper());
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        /// <summary>
        /// Beregner gennemsnitsværdien af de givende tal. Hvis der indtastes 10,20,30 skal den returnere 20
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns>Gennemsnittet</returns>
        static float CalculateAverageValue(float first, float second, float third)
        {
            float sum = first + second + third;
            float average = sum / 3; //Fejlen var at det dividerede summen med 2, men det skulle være 3, da der er tre numre
            return average;
        }

        /// <summary>
        /// Beregner den samlede sum op til det indtastede max tal hvis max er 5 skal den give 15
        /// </summary>
        static int CalculateSum(int max)
        {
            int sum = 0;

            for (int i = 1; i <= max; i++)
            {
                sum += i;
                Console.WriteLine($"Adding {i}, sum is now: {sum}");
            }
            return sum; //Fejlen var at funktionen returnerede sum + 1, efter at have talt den op
        }

        /// <summary>
        /// Tager imod et tal mellem 1,2,3 og skriver ud til konsollen hvad der er indtastet.
        /// </summary>
        static void WriteNumberWithSwitchCase()
        {
            Console.WriteLine("Enter a number between 1 and 3");
            int number = int.Parse(Console.ReadLine()); //Fejlen var at der blev brugt Console.Read som returnere ASCII-koden for en
                                                        //karakter, så 1 blev til 49, 2 til 50 og 3 til 51.
                                                        //Fix: brug Console.ReadLine og Parse det til en integer

            switch (number)
            {
                case 1:
                    Console.WriteLine("The number was 1");
                    break;
                case 2:
                    Console.WriteLine("The number was 2");
                    break;
                case 3:
                    Console.WriteLine("The number was 3");
                    break;
                default:
                    Console.WriteLine("Number was not 1, 2 or 3");
                    break;
            }
        }
    }
}