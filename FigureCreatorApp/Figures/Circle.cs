using FigureCreatorApp.Mangers;
using System.Text;

namespace FigureCreatorApp.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(List<Point> points) : base(points)
        {
            this.Center = points[0];
            CalculateRadius();
            CalculateArea();
            CalculatePerimetr();

        }
        public void CalculateRadius()
        {
            this.Radius = CalculateSide(Points[0], Points[1]);
        }

        public void CalculatePerimetr()
        {
            this.Perimetr = 2 * Math.PI * Radius;
        }

        public void CalculateArea()
        {
            this.Area = Math.PI * Radius * Radius;
        }

        public override void Rotate(double andle)
        {
            // TODO 
        }

        public override void Scale(double scale)
        {
            this.Radius *= scale;
            CalculateArea();
            CalculatePerimetr();
        }

        public static Circle Input()
        {
            List<Point> points = new List<Point>();

            Console.WriteLine(" Enter the coordinates of the center of the circle");
            double x = InputManager.GetDoubleInput();
            double y = InputManager.GetDoubleInput();
            points.Add(new Point(x, y));

            Console.WriteLine(" Enter the coordinates of the point that will be on the circle");
            x = InputManager.GetDoubleInput();
            y = InputManager.GetDoubleInput();
            points.Add(new Point(x, y));

            return new Circle(points);
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            String name = GetType().Name;

            result
                    .Append("    " + name)
                    .Append("\n Circle center coordinates")
                    .Append(0)
                    .Append(": x=")
                    .Append(Points[0].X)
                    .Append(", y=")
                    .Append(Points[0].Y)
                    .Append(";")
                    .Append("\n Coordinates of a point on a circle")
                    .Append(1)
                    .Append(": x=")
                    .Append(Points[1].X)
                    .Append(", y=")
                    .Append(Points[1].Y)
                    .Append(";")
                    .Append("\n Radius: ")
                    .Append(Radius)
                    .Append("\n Area: ")
                    .Append(Area)
                    .Append("\n Perimeter: ")
                    .Append(Perimetr)
                    .Append("\n");

            return result.ToString();
        }
    }
}
