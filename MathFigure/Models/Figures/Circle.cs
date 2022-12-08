using MathFigure.Interfaces;
using System;

namespace MathFigure.Models.Figures
{
    public record Circle : IFigure
    {
        public FigureTypes Type { get; } = FigureTypes.Circle;
        public double Area { get; }
        public double[] Sides { get; }

        public Circle(double radius)
        {
            ValidateRadius(radius);
            Sides = new[] { radius };
            Area = CalculateArea(radius);
        }

        public static double ValidateAndCalculateArea(double radius)
        {
            ValidateRadius(radius);
            return CalculateArea(radius);
        }

        static double CalculateArea(double radius)
        {
            return System.Math.PI * radius * radius;
        }

        static void ValidateRadius(double radius)
        {
            if(radius <= 0)
                throw new ArgumentException("Radius less or equal nill");
        }
    }
}
