using System;
using board;
using chess;

namespace chess_game
{
    class Program
    {
        static void Main(string[] args) {

            try { 
                Board initialBoard = new Board(8, 8);

                initialBoard.setPieceBoard(new Tower(initialBoard, Color.black), new Position(0, 0));
                initialBoard.setPieceBoard(new Tower(initialBoard, Color.black), new Position(1, 3));
                initialBoard.setPieceBoard(new King(initialBoard, Color.black), new Position(0, 2));

                initialBoard.setPieceBoard(new Tower(initialBoard, Color.black), new Position(3, 5));


                Screen.printBoard(initialBoard);
            }
            catch (BoardException error) {
                Console.WriteLine(error.Message);
            } 
            Console.ReadLine();
        }
    }
}