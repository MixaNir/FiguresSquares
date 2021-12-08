using System;
using SquareLibrary;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(new SquareLibrary.Models.Cirсle(23));
            Console.WriteLine(square.SquareProcess());
            square = new Square(new SquareLibrary.Models.Triangle(23, 23, 23));
            Console.WriteLine(square.SquareProcess());
            Console.ReadLine();
        }
    }
}
