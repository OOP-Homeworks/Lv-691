using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using osypov_hw10;


namespace TriangleTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestClass]
        public class TriangleUnitTest
        {
            [TestMethod]
            public void TriangleTestSquare()
            {
                Point a = new Point(0, 4);
                Point b = new Point(3, 0);
                Point c = new Point(0, 0);
                Triangle test = new Triangle(a, b, c);
                double expected = 6;
                Assert.AreEqual(Math.Round(test.Square()), expected);
            }
            [TestMethod]
            public void TriangleTestPerimeter()
            {
                Point a = new Point(0, 4);
                Point b = new Point(-3, 0);
                Point c = new Point(0, 0);
                Triangle test = new Triangle(a, b, c);
                double expected = 12;
                Assert.AreEqual(Math.Round(test.Perimeter()), expected);
            }
            [TestMethod]
            public void TriangleTestPrint()
            {
                Point a = new Point(0, 4);
                Point b = new Point(0, 1);
                Point c = new Point(0, 0);
                Triangle test = new Triangle(a, b, c);
                Assert.IsFalse(test.Print());
            }
        }
    }
}
