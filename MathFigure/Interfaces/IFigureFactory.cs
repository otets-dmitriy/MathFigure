using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure.Interfaces
{
    public interface IFigureFactory
    {
        IFigure CreateFigure(double radius);
        IFigure CreateFigure(double[] sides);
        IFigure CreateFigure(double sideA, double sideB, double sideC);
    }
}
