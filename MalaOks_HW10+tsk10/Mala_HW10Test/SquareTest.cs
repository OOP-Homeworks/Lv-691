using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalaOks_HW10;


namespace Mala_HW10Test
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void GetAreaSide5Success()
        {
            double sd = 5;
            string nm = "Square";
            Square sq = new(sd, nm);
            double expected = 25;
            sq.GetArea();

            Assert.AreEqual(expected, Convert.ToInt32(sq.Area));
        }

        [TestMethod]
        public void GetPerimeterSide5Success()
        {
            double sd = 5;
            string nm = "Square";
            Square sq = new(sd, nm);
            double expected = 20;
            sq.GetPerimeter();

            Assert.AreEqual(expected, Convert.ToInt32(sq.Perimeter));
        }
    }
}
