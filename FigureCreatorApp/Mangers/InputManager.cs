using FigureCreatorApp.Figures;
using System;
using System.Reflection;

namespace FigureCreatorApp.Mangers
{
    public static class InputManager
    {
        public static int ChooseOption(int min, int max)
        {
            Console.Write(" Enter integer number: ");

            int number;
            bool isInt = int.TryParse(Console.ReadLine(), out number);

            while (!isInt || number < min || number > max)
            {
                Console.Write(" This is not valid input. Please try again: ");
                isInt = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }

        public static double GetDoubleInput()
        {
            double number;

            Console.Write(" Enter double number: ");

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write(" This is not valid input. Please enter an integer value: ");
            }

            return number;
        }
        
        public static Point GetPoint()
        {
            Point point = new Point(0, 0);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine((i + 1) + " point ");
                double x = InputManager.GetDoubleInput();
                double y = InputManager.GetDoubleInput();

                point = new Point(x, y);
            }

            return point;
        }
    }
}
