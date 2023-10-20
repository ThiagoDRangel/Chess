using System;
using board;
using chess;

namespace chess_game
{
    class Screen {
        public static void printBoard(Board initialBoard) {
            for (int i = 0; i < initialBoard.line; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < initialBoard.column; j++) {
                    printPiece(initialBoard.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void printBoard(Board initialBoard, bool[,] allMoves) {

            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor backgroundMove = ConsoleColor.DarkGray;

            for (int i = 0; i < initialBoard.line; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < initialBoard.column; j++) {
                    if (allMoves[i, j]) {
                        Console.BackgroundColor = backgroundMove;
                    }
                    else {
                        Console.BackgroundColor = background;
                    }
                    printPiece(initialBoard.piece(i, j));
                    Console.BackgroundColor = background;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = background;
        }

        public static PositionChess readPositionChess() {
            string userMove = Console.ReadLine();
            char column = userMove[0];
            int line = int.Parse(userMove[1] + "");
            return new PositionChess(column, line);
        }
        public static void printPiece(Piece piece) {

            if (piece == null) {
                Console.Write("- ");
            }
            else { 
                if (piece.color == Color.white) {
                    Console.Write(piece);
                }
                else {
                    ConsoleColor playerColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(piece);
                    Console.ForegroundColor = playerColor;
                }
                Console.Write(" ");
            }
        }
    }
}
