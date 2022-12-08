using MathFigure.Models.Figures;
using MathFigure.Interfaces;

namespace MathFigure.Models.Figures
{
    public class Triangle : IFigure
    {
        public FigureTypes Type { get; }
        public double Area { get; }
        public double[] Sides { get; }
        public Triangle(double sideA, double sideB, double sideC) : this(new double[] { sideA, sideB, sideC }) { }
        public Triangle(double[] sides)
        {
            Sides = ValidateAndSortSides(sides);
            Area = CalculateArea(sides);
            Type = FigureTypes.Triangle;
        }

        public bool IsRectangular()
        {
            return Sides[2] == Math.Sqrt(Sides[0] * Sides[0] + Sides[1] * Sides[1]);
        }
        
        public static double ValidateAndCalculateArea(double[] sides)
        {
            ValidateAndSortSides(sides);
            return CalculateArea(sides);   
        }

        static double CalculateArea(double[] sides)
        {
            var halfPerimeter = sides.Sum() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) * (halfPerimeter - sides[1]) * (halfPerimeter - sides[2]));
        }

        static double[] ValidateAndSortSides(double[] sides)
        {
            if( sides.Length != 3 )
                throw new ArgumentException("Invalid sides count");
            if( sides.Any(x => x <= 0) )
                throw new ArgumentException("One or more sides less or equal nill");

            var orderedSides = sides.OrderBy(s => s).ToArray();

            if( orderedSides[2] > orderedSides[0] + orderedSides[1] )
                throw new ArgumentException("One side more then other sum");

            return orderedSides;
        }
    }
}
