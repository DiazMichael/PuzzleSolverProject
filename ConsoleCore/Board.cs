using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCore
{
    class Board
    {
        public List<Square[]> BoardPlayed = new List<Square[]>();
        public List<Sector> SectorsPlayed = new List<Sector>();
        public int Height { get; set; }
        public int Width { get; set; }

        public Board()
        {

        }
        public Board(int width, int height)
        {

            
            this.Width = width;
            this.Height = height;

            for (var x = 0; x < this.Width; x++)
            {
                var rowBuffer = new Square[Width];
                for (var y = 0; y < this.Height; y++)
                {
                    rowBuffer[y] = new Square(x, y);
                }
                BoardPlayed.Add(rowBuffer);
            }

            
        }
        public void AssignAwakeSquare(Square square, int value)
        {
            square.Value = value;
            square.PrintedValue = value.ToString();
            square.State = SquareState.Awake;
        }
        public void PrintBoard()
        {

            foreach (var row in BoardPlayed)
            {
                foreach (var square in row)
                {
                    Console.Write($"{square.Value}            ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
