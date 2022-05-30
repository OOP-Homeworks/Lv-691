using System;
using Homework_10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework_10Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestArea()
        {
            Point a = new Point(0, 4);
            Point b = new Point(3, 0);
            Point c = new Point(0, 0);
            Triangle test = new Triangle(a, b, c);
            double expected = 6;
            Assert.AreEqual(Math.Round(test.Square()), expected);
        }
        [TestMethod]
        public void TestPerimeter()
        {
            Point a = new Point(0, 4);
            Point b = new Point(3, 0);
            Point c = new Point(0, 0);
            Triangle test = new Triangle(a, b, c);
            double expected = 12;
            Assert.AreEqual(Math.Round(test.Perimeter()), expected);
        }
        [TestMethod]
        public void TestExist()
        {
            Point a = new Point(0, 4);
            Point b = new Point(0, 2);
            Point c = new Point(0, 0);
            Triangle test = new Triangle(a, b, c);
            Assert.IsFalse(test.Exist());
        }
    }
}
