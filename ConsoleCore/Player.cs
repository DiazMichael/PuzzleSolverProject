using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCore
{
    class Player
    {
        public void AssignPlayerSquare(Square square, int value)
        {
            square.Value = value;
            square.State = SquareState.Set;
            square.PrintedValue = value.ToString();
        }
    }
}
