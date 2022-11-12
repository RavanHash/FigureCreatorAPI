using System;

namespace FigureCreatorApp.Figures
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public override String ToString()
        {
            String result = "( " + X + "; " + Y + " ) ";
            return result;
        }

        public override bool Equals(Object obj)
        {
            if (this == obj)
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;

            Point point = (Point)obj;

            return point.X.CompareTo(X) == 0 && point.Y.CompareTo(Y) == 0;
        }
    }
}
