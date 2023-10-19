using System;
using board;

namespace chess_game
{
    class Screen
    {
        public static void printBoard(Board initialBoard)
        {
            for (int i = 0; i < initialBoard.line; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < initialBoard.column; j++)
                {
                    if (initialBoard.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        printPiece(initialBoard.piece(i, j));
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void printPiece(Piece piece) {
            if (piece.color == Color.white) {
                Console.WriteLine(piece);
            }
            else {
                ConsoleColor playerColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(piece);
                Console.ForegroundColor = playerColor;
            }
        }
    }
}
