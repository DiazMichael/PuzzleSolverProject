using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCore
{
    enum SectorState
    {
        Completed,
        Uncompleted
    }
    class Sector
    {
        public SectorState SectorState { get; set; }
        public int Size { get; set; }
        public Square[] Squares { get; set; }
        public int SectorNumber { get; set; }


        public Sector()
        {


        }

        public Sector(Square[] sectionSquares)
        {
            this.Squares = sectionSquares;
            this.Size = sectionSquares.Count();

            for (var i = 0; i <= this.Size; i++)
            {
                NumbersAvailable.Add(i);
            }


            foreach (var square in sectionSquares)
            {
                square.Sector = this;

            }
        }

    }
}