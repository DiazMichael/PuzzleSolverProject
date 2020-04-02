using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCore
{
    class PuzzleSolver
    {
        public void GetPuzzleSolution(Board board)
        {
            for (var i = 0; i < board.Width; i++)
            {
                for (var j = 0; j < board.Height; j++)
                {
                    if (board.BoardPlayed[i][j].Value == 0)
                    {
                        if (PuzzleSolver.GetPotentialValues(board, board.BoardPlayed[i][j]).Any())
                        {
                            board.BoardPlayed[i][j].Value = board.BoardPlayed[i][j].Sector.NumbersAvailable[0];
                        }
                    }
                }
            }

        }
        public bool IsBoardFull(Board board)
        {
            foreach (var row in board.BoardPlayed)
            {
                foreach (var square in row)
                {
                    if (square.Value == 0)
                        return false;
                }
            }
            return true;
        }
        public static void GetPotentialValues(Board board, Square square)
        {

            var potentialValues = new List<int>();
            if (square.Value != 0)
            {
                return;
            }
            else
            {
                for (var i = 1; i <= square.Sector.Size; i++)
                {
                    for (var j = 0; j < square.Sector.Size; j++)
                    {
                        if (square.Sector.Squares[j] == )
                    }
                }
            }


        }
        public static bool CheckNeighbourNumbers(Board board, Square square)
        {
            return Square.GetSquare(board, square.AxisX - 1, square.AxisY - 1).Value == square.Value ||
                   Square.GetSquare(board, square.AxisX, square.AxisY - 1).Value == square.Value ||
                   Square.GetSquare(board, square.AxisX + 1, square.AxisY - 1).Value == square.Value ||
                   Square.GetSquare(board, square.AxisX - 1, square.AxisY).Value == square.Value ||
                   Square.GetSquare(board, square.AxisX + 1, square.AxisY).Value == square.Value ||
                   Square.GetSquare(board, square.AxisX - 1, square.AxisY + 1).Value == square.Value ||
                   Square.GetSquare(board, square.AxisX, square.AxisY + 1).Value == square.Value ||
                   Square.GetSquare(board, square.AxisX + 1, square.AxisY + 1).Value == square.Value;

        }
    }
}