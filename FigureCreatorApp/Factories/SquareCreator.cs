using FigureCreatorApp.Figures;
using System.Collections.Generic;

namespace FigureCreatorApp.Factories
{
    public class SquareCreator : FigureCreator
    {
        public override Figure CreateFigure()
        {
            return Square.Input();
        }

        public override Figure CreateFigure(List<Point> points)
        {
            return new Square(points);
        }
    }
}
