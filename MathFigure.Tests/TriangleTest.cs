namespace MathFigure.Tests
{
    [TestClass]
   public class TriangleTest
   {
        [TestMethod]
        public void CanCalculateArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area);
        }

        [TestMethod]
        public void CanStaticCalculateArea()
        {
            Assert.AreEqual(6, Triangle.ValidateAndCalculateArea(new double[] { 3, 4, 5 }));
        }

        [TestMethod]
        public void CanDefineRectangular()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CanNotPassNegativeSide()
        {
            new Triangle(-3, 1, 2);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CanNotPassNillSide()
        {
            new Triangle(0, 2, 2);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CanNotPassTooLongSide()
        {
            new Triangle(1, 2, 5);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CanNotPassTwoSides()
        {
            new Triangle(new double[] { 1, 2 });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CanNotPassFourSides()
        {
            new Triangle(new double[] { 2, 2, 3, 2 });
        }
    }
}
