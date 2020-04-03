using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCore
{
    class PuzzleSolver
    {
        public static void GetPuzzleSolution(Board board)
        {
            for (var x = 0; x < board.Width; x++)
            {


                for (var y = 0; y < board.Height; y++)
                {
                    if (board.BoardPlayed[x][y].Value == 0)
                    {
                        for (var n = 1; n <= board.BoardPlayed[x][y].Sector.Size; n++)
                        {
                            if (PuzzleSolver.IsPossible(board, board.BoardPlayed[x][y], n))
                            {
                                board.BoardPlayed[x][y].Value = n;
                                GetPuzzleSolution(board);
                                board.BoardPlayed[x][y].Value = 0;
                            }
                        }
                        return;
                    }
                }
            }
            board.PrintBoard();
            Console.WriteLine("More solutions");

        }
        public static bool IsPossible(Board board, Square square, int possibleNumber)
        {

            for (var i = 0; i < square.Sector.Size; i++)
            {
                if (square.Sector.Squares[i].Value == possibleNumber)
                    return false;
            }
                if (IsEqualNeighbourNumbers(board,square,possibleNumber))
                    return false;
                return true;

        }
        public static bool IsEqualNeighbourNumbers(Board board,Square square, int possibleNumber)
        {
            var possible = (Square.GetSquareValue(board, square.Row - 1, square.Column - 1) == possibleNumber ||
                   Square.GetSquareValue(board, square.Row - 1, square.Column) == possibleNumber ||
                   Square.GetSquareValue(board, square.Row - 1, square.Column + 1) == possibleNumber ||
                   Square.GetSquareValue(board, square.Row, square.Column - 1) == possibleNumber ||
                   Square.GetSquareValue(board, square.Row, square.Column + 1) == possibleNumber ||
                   Square.GetSquareValue(board, square.Row + 1, square.Column - 1) == possibleNumber ||
                   Square.GetSquareValue(board, square.Row + 1, square.Column) == possibleNumber ||
                   Square.GetSquareValue(board, square.Row + 1, square.Column + 1) == possibleNumber) ? true : false;

            return possible;

        }
    }
}