using System;
using System.Collections.Generic;
using FigureCreatorApp.Mangers;

namespace FigureCreatorApp.Figures
{
    public class Square : Polygon
    {
        public Square(List<Point> points) : base(points) { }

        public static Square Input()
        {
            List<Point> points = new List<Point>();

            Console.WriteLine(" Enter shape coordinates");
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + " point ");
                double x = InputManager.GetDoubleInput();
                double y = InputManager.GetDoubleInput();

                points.Add(new Point(x, y));
            }
            Console.WriteLine(" The figure has been built! ");
            return new Square(points);
        }
    }
}
