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
        public int Row { get; set; }
        public int Column { get; set; }
        public int Value { get; set; }
        public string PrintedValue { get; set; }
        public Sector Sector { get; set; }
        public Board Board { get; set; }

        public Square()
        {
            this.Value = 0;
            this.PrintedValue = "     ";
            Console.WriteLine($"A square has been generated");
        }
        public Square(int x, int y)
        {
            this.Row = x;
            this.Column = y;
            State = SquareState.Empty;
            this.PrintedValue = $"[{this.Row},{this.Column}]";
        }
        public static int GetSquareValue(Board board, int x, int y)
        {
            if (x < 0 || x > board.Height - 1 || y < 0 || y > board.Width - 1)
                return 0;
            else
                return board.BoardPlayed[x][y].Value;
        }
        public static Square GetSquare(Board board, int x, int y)
        {

            if (x < 0 || x > board.Height - 1 || y < 0 || y > board.Width - 1)
                return new Square();
            else
                return board.BoardPlayed[x][y];
        }
    }
}
