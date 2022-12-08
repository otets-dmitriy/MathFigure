namespace MathFigure.Tests
{
    [TestClass]
    public class FigureFactoryTest
    {
        IFigureFactory _figureFactory;
        public FigureFactoryTest()
        {
            _figureFactory= new FigureFactory();
        }
        [TestMethod]
        public void CanCreateCircleByRadius()
        {
            var figure = _figureFactory.CreateFigure(5);
            Assert.IsTrue(figure is Circle);
        }

        [TestMethod]
        public void CanCreateCircleByArray()
        {
            var figure = _figureFactory.CreateFigure(new double[] { 5 });
            Assert.IsTrue(figure is Circle);
        }

        [TestMethod]
        public void CanCreateTriangleBySides()
        {
            var figure = _figureFactory.CreateFigure( 3, 4, 5 );
            Assert.IsTrue(figure is Triangle);
        }

        [TestMethod]
        public void CanCreateTriangleByArray()
        {
            var figure = _figureFactory.CreateFigure(new double[] { 3, 4, 5 });
            Assert.IsTrue(figure is Triangle);
        }
    }
}