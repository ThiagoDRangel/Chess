using System;
using System.Collections.Generic;
using board;
using chess;

namespace chess_game
{
    class Screen {

        public static void createdNewGame(StartGame game) {
            printBoard(game.initialBoard);
            Console.WriteLine();
            printCapturedPieces(game);
            Console.WriteLine();
            Console.WriteLine("Turns: " + game.turn);
            Console.WriteLine("Wait move: " + game.player);
        }

        public static void printCapturedPieces(StartGame game) {
            Console.WriteLine("Captured pieces:");
            Console.Write("White pieces: ");
            printPiecesToColor(game.capturetedPiecesToColor(Color.white));
            Console.WriteLine();
            Console.Write("Black pieces: ");
            ConsoleColor defaultConsole = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            printPiecesToColor(game.capturetedPiecesToColor(Color.black));
            Console.ForegroundColor = defaultConsole;
            Console.WriteLine();
        }

        public static void printPiecesToColor(HashSet<Piece> bundle) {
            Console.Write("[");
            foreach (Piece x in bundle) { 
                Console.Write(x + " ");
            }
            Console.Write("]");
        }
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

            ConsoleColor defaultBackground = Console.BackgroundColor;
            ConsoleColor backgroundMove = ConsoleColor.DarkGray;

            for (int i = 0; i < initialBoard.line; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < initialBoard.column; j++) {
                    if (allMoves[i, j]) {
                        Console.BackgroundColor = backgroundMove;
                    }
                    else {
                        Console.BackgroundColor = defaultBackground;
                    }
                    printPiece(initialBoard.piece(i, j));
                    Console.BackgroundColor = defaultBackground;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = defaultBackground;
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
