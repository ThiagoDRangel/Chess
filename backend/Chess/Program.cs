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

                    try { 

                        Console.Clear();
                        Screen.createdNewGame(match);

                        Console.WriteLine();
                        Console.Write("Piece movie: ");
                        Position moveOrigin = Screen.readPositionChess().toPosition();

                        match.validOriginPosition(moveOrigin);

                        bool[,] allMoves = match.initialBoard.piece(moveOrigin).movesPieceInBoard();

                        Console.Clear();
                        Screen.printBoard(match.initialBoard, allMoves);

                        Console.WriteLine();
                        Console.Write("Piece destination: ");
                        Position moveDestination = Screen.readPositionChess().toPosition();
                        match.validatePositionToDestiny(moveOrigin, moveDestination);

                        match.gamePlay(moveOrigin, moveDestination);
                    }
                    catch (BoardException e) { 
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

            }
            catch (BoardException error) {
                Console.WriteLine(error.Message);
            } 
            Console.ReadLine();
        }
    }
}