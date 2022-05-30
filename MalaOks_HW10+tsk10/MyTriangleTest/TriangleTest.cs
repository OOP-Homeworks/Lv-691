using MalaOks_Tsk10;

namespace MyTriangleTest
{
    [TestClass]
    public class TriangleTest
    {
        //не можу в назві метода прописувати вхідні параметри і очікуване значення дуже довга назва
        [TestMethod]
        public void TestDistanceReturnExpectedNum()
        {
            MyPoint p1 = new(1, 3);
            MyPoint p2 = new(4, 1);
            int expect = 4;

            int res = Convert.ToInt32(p1.Distance(p2));

            Assert.AreEqual(expect, res);

        }


        [TestMethod]
        public void TestGetPreimeterReturnExpectedNum()
        {
            MyPoint p1 = new(1, 3);
            MyPoint p2 = new(4, 1);
            MyPoint p3 = new(1, 1);
            MyTriangle tr = new(p1, p2, p3);
            int expect = 9;

            tr.GetPerimeter(p1, p2, p3);

            Assert.AreEqual(expect, Convert.ToInt32(tr.Perimeter));
        }  
        

        [TestMethod]
        public void TestGetSquareReturnExpectedNum()
        {
            MyPoint p1 = new(1, 3);
            MyPoint p2 = new(4, 1);
            MyPoint p3 = new(1, 1);
            MyTriangle tr = new(p1, p2, p3);
            int expect = 3;

            tr.GetSquare(p1, p2, p3);

            Assert.AreEqual(expect, tr.Square);

        }
    }
}