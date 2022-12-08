using MathFigure.Interfaces;
using MathFigure.Models.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure.Models
{
    public class FigureFactory : IFigureFactory
    {
        public IFigure CreateFigure(double radius)
        {
            return new Circle(radius);
        }

        public IFigure CreateFigure(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }

        public IFigure CreateFigure(double[] sides)
        {
            switch( sides.Length )
            {
                case 1:
                {
                    return new Circle(sides[0]);
                }
                case 3:
                {
                    return new Triangle(sides);
                }
                default:
                    throw new ArgumentException("Invalid sides count");
            }
        }
    }
}
