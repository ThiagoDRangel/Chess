using System;
using board;
using chess;

namespace chess_game
{
    class Program
    {
        static void Main(string[] args) {

            try { 
                StartGame match = new StartGame();

                while (!match.gameFinished) {

                    Console.Clear();
                    Screen.printBoard(match.initialBoard);

                    Console.WriteLine();
                    Console.WriteLine("Piece movie: ");
                    Position moveOrigin = Screen.readPositionChess().toPosition();

                    bool[,] allMoves = match.initialBoard.piece(moveOrigin).movesPieceInBoard();

                    Console.Clear();
                    Screen.printBoard(match.initialBoard, allMoves);

                    Console.WriteLine();
                    Console.WriteLine("Piece destination: ");
                    Position moveDestination = Screen.readPositionChess().toPosition();

                    match.makeMovie(moveOrigin, moveDestination);
                }

            }
            catch (BoardException error) {
                Console.WriteLine(error.Message);
            } 
            Console.ReadLine();
        }
    }
}