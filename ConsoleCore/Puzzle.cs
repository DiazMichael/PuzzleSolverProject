using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCore
{
    class Puzzle
    {
        public Board Board { get; set; }


        public Puzzle()
        {
            this.Board = new Board(5, 5);

            Board.AssignAwakeSquare(Square.GetSquare(Board, 0, 1), 1);
            Board.AssignAwakeSquare(Square.GetSquare(Board, 1, 3), 2);
            Board.AssignAwakeSquare(Square.GetSquare(Board, 3, 1), 4);
            Board.AssignAwakeSquare(Square.GetSquare(Board, 3, 3), 5);
            Board.AssignAwakeSquare(Square.GetSquare(Board, 4, 3), 4);
            Board.PrintBoard();
            Board.SectorsPlayed = new List<Sector>();

            Board.SectorsPlayed.Add(new Sector(new Square[] { Square.GetSquare(Board, 0, 0),
                                                              Square.GetSquare(Board, 0, 1),
                                                              Square.GetSquare(Board, 1, 1),
                                                              Square.GetSquare(Board, 2, 1),
                                                              Square.GetSquare(Board, 2, 2)}));

            Board.SectorsPlayed.Add(new Sector(new Square[] { Square.GetSquare(Board, 1, 0),
                                                              Square.GetSquare(Board, 2, 0),
                                                              Square.GetSquare(Board, 3, 0),
                                                              Square.GetSquare(Board, 3, 1),
                                                              Square.GetSquare(Board, 4, 0)}));

            Board.SectorsPlayed.Add(new Sector(new Square[] { Square.GetSquare(Board, 0, 2),
                                                              Square.GetSquare(Board, 0, 3),
                                                              Square.GetSquare(Board, 1, 2),
                                                              Square.GetSquare(Board, 1, 3),
                                                              Square.GetSquare(Board, 2, 3)}));

            Board.SectorsPlayed.Add(new Sector(new Square[] { Square.GetSquare(Board, 0, 4),
                                                              Square.GetSquare(Board, 1, 4),
                                                              Square.GetSquare(Board, 2, 4),
                                                              Square.GetSquare(Board, 3, 4),
                                                              Square.GetSquare(Board, 3, 3)}));

            Board.SectorsPlayed.Add(new Sector(new Square[] { Square.GetSquare(Board, 4, 1),
                                                              Square.GetSquare(Board, 4, 2),
                                                              Square.GetSquare(Board, 3, 2),
                                                              Square.GetSquare(Board, 4, 3),
                                                              Square.GetSquare(Board, 4, 4)}));


        }
        }
    }
