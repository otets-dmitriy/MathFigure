namespace MathFigure.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CanCalculateArea()
        {
            var circle = new Circle(2);
            Assert.AreEqual(Math.PI*2*2, circle.Area);
        }

        [TestMethod]
        public void CanStaticCalculateArea()
        {
            Assert.AreEqual(Math.PI * 2 * 2, Circle.ValidateAndCalculateArea(2));
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CanNotPassNegativeRadius()
        {
            new Circle(-2);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CanNotPassNillRadius()
        {
            new Circle(0);
        }
    }
}
