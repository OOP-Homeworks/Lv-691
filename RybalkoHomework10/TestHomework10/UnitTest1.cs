using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RybalkoHomework10;

namespace TestHomework10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Distant_P1andP2_4result()
        { 
            Point Point1 = new Point(1, 2);
            Point Point2 = new Point(1, 6);
            Point Point3 = new Point(6, 2);
            double result = 4;

            Triangle TriangleTest = new Triangle(Point1, Point2, Point3);
            double actual = TriangleTest.Distant(Point1, Point2);

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Perimetr_3and4and5_12result()
        {
            Point Point1 = new Point(0, 0);
            Point Point2 = new Point(0, 3);
            Point Point3 = new Point(4, 0);
            double result = 12;

            Triangle TriangleTest = new Triangle(Point1, Point2, Point3);
            double actual = TriangleTest.Perimeter();

            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void Square_3and4and5_6result()
        {
            Point Point1 = new Point(0, 0);
            Point Point2 = new Point(0, 3);
            Point Point3 = new Point(4, 0);
            double result = 6;

            Triangle TriangleTest = new Triangle(Point1, Point2, Point3);
            double actual = TriangleTest.Square();

            Assert.AreEqual(result, actual);
        }
    }
}