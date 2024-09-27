using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lav et array som kan repræsentere et skakbræt
//Det skal være muligt at se hvilke brikker der er på felterne
//Hint: Brug byte/int værdier eller enum som datatype til at beskrive forskellige briktyper
//Fx 0 = Ingen brik, 1 = Bonde, 2 = Springer osv.
//Skriv skakbrættet ud til skærmen

namespace Dag_4___Øvelse_4
{
    enum pieces: byte
    {
        Empty = 0,
        White_Pawn = 1,
        White_Rook = 2,
        White_Knight = 3,
        White_Bishop = 4,
        White_Queen = 5,
        White_King = 6,
        Black_Pawn = 7,
        Black_Rook = 8,
        Black_Knight = 9,
        Black_Bishop = 10,
        Black_Queen = 11,
        Black_King = 12
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] chessBoard =
            {
                {8, 9, 10, 11, 12, 10, 9, 8},
                {7, 7, 7, 7, 7, 7, 7, 7},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {1, 1, 1, 1, 1, 1, 1, 1},
                {2, 3, 4, 5, 6, 4, 3, 2}
            };
            
            //Printer chessBoard
            for (int x = 0; x < chessBoard.GetLength(0); x++)
            {
                for (int y = 0; y < chessBoard.GetLength(1); y++)
                {
                    for
                    #region Chesspiece coloring
                    switch (chessBoard[x,y])
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("P"); //White Pawn
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("R"); //White Rook
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("K"); //White Knight
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("B"); //White Bishop
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Q"); //White Queen
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("*"); //White King
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("P"); //Black Pawn
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("R"); //Black Rook
                            break;
                        case 9:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("K"); //Black Knight
                            break;
                        case 10:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("B"); //Black Bishop
                            break;
                        case 11:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("Q"); //Black Queen
                            break;
                        case 12:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("*"); //Black King
                            break;
                        default:
                            Console.Write(" "); //Empty space
                            break;
                    }
#endregion
                    //Console.Write(chessBoard[x,y]);
                }
                Console.WriteLine();
            }



            //Pauses the program
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
    }
}
