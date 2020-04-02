using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCore
{
    public enum SquareState
    {
        Empty,
        Awake,
        Set
    }

    class Square
    {
        public SquareState State { get; set; }
        public int AxisY { get; set; }
        public int AxisX { get; set; }
        public int Value { get; set; }
        public string PrintedValue { get; set; }
        public Sector Sector { get; set; }

        public Square()
        {
            this.PrintedValue = "     ";
            Console.WriteLine($"A square has been generated");
        }
        public Square(int x, int y)
        {
            this.AxisY = y;
            this.AxisX = x;
            State = SquareState.Empty;
            this.PrintedValue = $"[{this.AxisX},{this.AxisY}]";
        }
        public static Square GetSquare(Board board, int x, int y)
        {
            return board.BoardPlayed[y][x];
        }
    }
}
