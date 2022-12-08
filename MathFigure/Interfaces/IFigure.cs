using MathFigure.Models.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure.Interfaces
{
    public interface IFigure
    {
        FigureTypes Type { get; }
        double Area { get; }
        double[] Sides { get; }
    }
}
