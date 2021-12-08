using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Models
{
    public class Cirсle: IFigure
    {
        public string name { get; set; }
        private double line = 0;

        public Cirсle(double radius) { UpdateRadius(radius); this.name = "Circle"; }
        public void UpdateRadius(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException("Invalid values (value >= 0)");
            else line = radius;
        }
        public double GetRadius() { return line; }
        public double Square() { return Math.PI * line * line; }
    }
}
