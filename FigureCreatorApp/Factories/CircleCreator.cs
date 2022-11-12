using FigureCreatorApp.Figures;
using System.Collections.Generic;

namespace FigureCreatorApp.Factories
{
    public class CircleCreator : FigureCreator
    {
        public override Figure CreateFigure()
        {
            return Circle.Input();
        }

        public override Figure CreateFigure(List<Point> points)
        {
            return new Circle(points);
        }
    }
}
