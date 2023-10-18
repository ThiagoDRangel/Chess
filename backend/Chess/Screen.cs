using System;
using board;

namespace Chess
{
    class Screen
    {
        public static void printBoard(Board initialBoard)
        {
            for (int i = 0; i < initialBoard.line; i++)
            {
                for (int j = 0; j < initialBoard.column; j++)
                {
                    if (initialBoard.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(initialBoard.piece(i, j) + " ");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
