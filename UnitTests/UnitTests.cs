using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SquareLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    class UnitTests
    {
        [TestClass]
        public class UnitTest
        {
            [TestMethod]
            public void TriangleWithWrongParameters()
            {
                double a = 11;
                double b = 1.2;
                double c = 0.2;
                try
                {
                    new Square(new Triangle(a, b, c));
                    Assert.Fail("Exception not thrown");
                }
                catch (ArgumentOutOfRangeException) { }
            }

            [TestMethod]
            public void TriangleWithSideLessZero()
            {
                double a = 11;
                double b = 0;
                double c = -1;
                try
                {
                    new Square(new Triangle(a, b, c));
                    Assert.Fail("Exception not thrown");
                }
                catch (ArgumentOutOfRangeException) { }
            }
            [TestMethod]
            public void CalculateTriangleAreaTest()
            {
                double a = 3.0;
                double b = 4.0;
                double c = 5.0;
                Square triangle = new Square(new Triangle(a, b, c));
                double area = triangle.SquareProcess();
                Assert.IsTrue(area <= 6.0 && area > 5.99);
                Assert.IsTrue(((Triangle)triangle.GetFigure()).IsRectangular());
            }

            [TestMethod]
            public void CheckIfTriangleIsRight()
            {
                double a = 5.0;
                double b = 5.0;
                double c = 5.0;
                Square triangle = new Square(new Triangle(a, b, c));
                Assert.IsTrue(((Triangle)triangle.GetFigure()).IsRight());
            }

            [TestMethod]
            public void CircleWithWrongParameters()
            {
                double radius = -1;
                try
                {
                    new Square(new Cirсle(radius));
                    Assert.Fail("Exception not thrown");
                }
                catch (ArgumentOutOfRangeException) { }
            }

            [TestMethod]
            public void CalculateCircleAreaTest()
            {
                double radius = 3.0;
                Square circle = new Square(new Cirсle(radius));
                Assert.AreEqual(Math.PI * Math.Pow(3, 2), circle.SquareProcess());
            }
          
        }
    }
}
