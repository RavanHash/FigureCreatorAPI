using System;
using System.Collections.Generic;

namespace FigureCreatorApp.Figures
{
    public class Polygon : Figure
    {
        public Polygon(List<Point> points) : base(points)
        {
            this.CalculateCenter();
            this.CalculateArea();
            this.CalculatePerimetr();
        }

        public void CalculateArea()
        {
            Area = 0;
            for (int i = 0; i < Points.Count - 1; i++)
            {
                Area += Math.Abs((Points[i].X * Points[i + 1].Y) - (Points[i].Y * Points[i + 1].X)) / 2d;
            }
        }

        public void CalculatePerimetr()
        {
            Perimetr = 0;

            for (int i = 0; i < Points.Count - 1; i++)
            {
                Perimetr += Math.Sqrt(Pow(Points[i + 1].X - Points[i].X) + Pow(Points[i + 1].Y - Points[i].Y));
            }
            Perimetr += Math.Sqrt(Pow(Points[Points.Count - 1].X - Points[0].X) + Pow(Points[Points.Count - 1].Y - Points[0].Y));
        }

        public override void Scale(double scale)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                double x = (Points[i].X - Center.X) * scale + Center.X;
                double y = (Points[i].Y - Center.Y) * scale + Center.Y;
                Points[i] = new Point(x, y);
            }
            CalculateArea();
            CalculatePerimetr();
        }

        public override void Rotate(double angle)
        {
            angle = angle * Math.PI / 180;
            for (int i = 0; i < Points.Count; i++)
            {
                double x = (Points[i].X - Center.X) * Math.Cos(angle) - (Points[i].Y - Center.Y) * Math.Sin(angle);
                double y = (Points[i].X - Center.X) * Math.Sin(angle) + (Points[i].Y - Center.Y) * Math.Cos(angle);
                Points[i] = new Point(x, y);
            }
        }

        public double Pow(double a)
        {
            return a * a;
        }
    }
}
