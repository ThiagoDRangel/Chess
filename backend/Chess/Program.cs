using System;
using board;
using chess;

namespace chess_game
{
    class Program
    {
        static void Main(string[] args) {

            PositionChess positionChess = new PositionChess('c', 7);

            Console.WriteLine(positionChess);

            Console.WriteLine(positionChess.toPosition());

            Console.ReadLine();
        }
    }
}