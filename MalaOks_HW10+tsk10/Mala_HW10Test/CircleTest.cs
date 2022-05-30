using MalaOks_HW10;

namespace Mala_HW10Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetAreaRadius5Success()
        {
            double rd = 5;
            string nm = "Circle";
            Circle cr = new(rd, nm);
            double expected = 79;
            cr.GetArea();

            Assert.AreEqual(expected, Convert.ToInt32(cr.Area));
        }

        [TestMethod]
        public void GetPerimeterRadius5Success()
        {
            double rd = 5;
            string nm = "Circle";
            Circle cr = new(rd, nm);
            double expected = 31;
            cr.GetPerimeter();

            Assert.AreEqual(expected, Convert.ToInt32(cr.Perimeter));
        }
        

    }
}