using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Models
{
    public class Triangle: IFigure
    {
        public string name { get; set; }
        private double[] lines = new double[3];
        private bool rightTriangle = false;

        public Triangle(double line0, double line1, double line2) {
            this.UpdateSides(line0, line1, line2);
            this.name = "Triangle";
        }

        public void UpdateSides(double line0, double line1, double line2) {
            if (line0 <= 0 || line1 <= 0 || line2 <= 0) throw new ArgumentOutOfRangeException("Invalid values (value >= 0)");
            if (line0 < line1 + line2 && line1 < line0 + line2 && line2 < line1 + line0)
            {
                this.lines[0] = line0;
                this.lines[1] = line1;
                this.lines[2] = line2;
                this.name = "Triangle";
                this.rightTriangle = lines[0] == lines[1] && lines[0] == lines[2] ? true : false;
            }
            else throw new ArgumentOutOfRangeException("Not a triangle");
        }
        public double[] GetSides() { return lines; }
        public double Square() {
            if (rightTriangle)
                return (Math.Sqrt(3) * lines[0] * lines[0]) / 4;
            else
            {
                var p = (lines[0] + lines[1] + lines[2]) / 2;
                return Math.Sqrt(p * (p - lines[0]) * (p - lines[1]) * (p - lines[2]));
            }
        }

        public bool IsRectangular()
        {
            return Math.Pow(lines[0], 2) == Math.Pow(lines[1], 2) + Math.Pow(lines[2], 2) ||
                Math.Pow(lines[1], 2) == Math.Pow(lines[0], 2) + Math.Pow(lines[2], 2) ||
                Math.Pow(lines[2], 2) == Math.Pow(lines[0], 2) + Math.Pow(lines[1], 2);
        }

        public bool IsRight() { return rightTriangle; }
    }
}
