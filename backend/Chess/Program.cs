using System;
using board;
using Chess;

namespace chess
{
    class Program
    {
        static void Main(string[] args) {

            Board initialBoard = new Board(8, 8);

            Screen.printBoard(initialBoard);
            Console.ReadLine();
        }
    }
}