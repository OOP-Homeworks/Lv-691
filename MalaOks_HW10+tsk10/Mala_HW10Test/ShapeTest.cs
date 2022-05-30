using MalaOks_HW10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_HW10Test
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void CompareToSuccess()
        {
            double rd = 5;
            string nm = "Circle";
            Circle cr = new(rd, nm);
            cr.GetArea();

            double sd = 5;
            string nm1 = "Square";
            Square sq = new(sd, nm1);
            sq.GetArea();


            int expect = 1;
            Assert.AreEqual(expect, cr.CompareTo(sq));

        }
    }
}
