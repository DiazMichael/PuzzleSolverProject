using System;
using System.Collections.Generic;

namespace ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {

            var puzzle = new Puzzle();
            Console.WriteLine("\n\n\n\n Press anything to show the solution/s.\n\n");
            Console.ReadLine();
            PuzzleSolver.GetPuzzleSolution(puzzle.Board);
        }

        
    }
}
