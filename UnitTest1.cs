using hw10;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestArea()
        {
            Point a = new Point(0,4);
            Point b = new Point(3,0);
            Point c = new Point(0,0);
            Triangle test = new Triangle(a, b, c);
            double expected = 6;
            Assert.AreEqual(Math.Round(test.Area()), expected);
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
            Point b = new Point(0, 1);
            Point c = new Point(0, 0);
            Triangle test = new Triangle(a, b, c);
            Assert.IsFalse(test.Exist());
        }
    }
}
