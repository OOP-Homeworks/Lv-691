using HW1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeworksTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestTrianglePerimeter()
        {
            Point p1 = new Point(2, 3);
            Point p2 = new Point(4, 5);
            Point p3 = new Point(10, 12);

            double perExpected = 24.09;

            Triangle triangle = new Triangle(p1, p2, p3);

            double perimeter = triangle.Perimeter();

            Assert.AreEqual(perExpected, perimeter);

        }

        [TestMethod]
        public void TestTriangleSquare()
        {
            Point p1 = new Point(2, 3);
            Point p2 = new Point(4, 5);
            Point p3 = new Point(10, 12);

            double sqExpected = 1.03;

            Triangle triangle = new Triangle(p1, p2, p3);

            double square = triangle.Square();

            Assert.AreEqual(sqExpected, square);

        }
    }
}
