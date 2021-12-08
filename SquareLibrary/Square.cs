using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareLibrary.Models;

namespace SquareLibrary
{
    public class Square
    {
        IFigure figure;

        public Square(IFigure tempFigure) { this.figure = tempFigure; }

        public double SquareProcess() { return figure.Square(); }

        public IFigure GetFigure() { return figure; }
    }
}
