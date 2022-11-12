using FigureCreatorApp.Figures;
using System.Collections.Generic;

namespace FigureCreatorApp.Factories
{
    public class TriangleCreator : FigureCreator
    {
        public override Figure CreateFigure()
        {
            return Triangle.Input();
        }

        public override Figure CreateFigure(List<Point> points)
        {
            return new Triangle(points);
        }
    }
}
