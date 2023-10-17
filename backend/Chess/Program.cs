using board;
using System;

namespace chess
{
    class Program
    {
        static void Main(string[] args) {

            Position initialPosition;

            initialPosition = new Position(3, 4);

            Console.WriteLine("Position: " + initialPosition);
            Console.ReadLine();
        }
    }
}