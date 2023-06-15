using System;

namespace TicTacToe_Winner_Identifier_Challenge
{
    class Program
    {
        public static string[,] board = new string[3, 3]
            {
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" }
            };
        public static int counter;
        static void Main(string[] args)
        {
            //horizontal a
            //for (int i = 0,j=0; i < board.GetLength(0); i++,j++)
            //{
            //    if(i==j)
            //    {
            //        board[i, j] = "x";
            //    }
            //}

            //horizontal b
            //for (int i =0, j=2; i<board.GetLength(0);i++,j--)
            //{
            //    board[i, j] = "x";
            //}

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    // change i for vertical or j for horizontal lines
                    //board[i, 2] = "x";
                    Console.Write(board[i, j] + " ");
                    if (j == 2)
                    {
                        Console.Write("\n");
                    }
                    if (board[i, j] == "x")
                    {
                        counter++;
                    }
                }
                
            }
            if (counter == 3)
            {
                Console.WriteLine("winner");
            }
            Console.ReadKey();
        }
    }
}

