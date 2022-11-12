using System;

namespace FigureCreatorApp.Menu
{
    public static class MenuUI
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("\n Choose one option:\n");
            Console.WriteLine(" 1. Show all figures.");
            Console.WriteLine(" 2. Create a figure.");
            Console.WriteLine(" 3. Change figure.");
            Console.WriteLine(" 4. Save to file.");
            Console.WriteLine("\n 0. Exit.\n");
        }

        public static void ShowCreateFigureMenu()
        {
            Console.WriteLine("\n Choose one option:\n");
            Console.WriteLine(" 1. Square");
            Console.WriteLine(" 2. Rectangle");
            Console.WriteLine(" 3. Triangle");
            Console.WriteLine(" 4. Circle");
            Console.WriteLine("\n 0. Back to Main Menu.\n");
        }
        
        public static void ShowSelectChangeFigureMenu()
        {
            Console.WriteLine("\n 0. Back to Main Menu.");
            Console.WriteLine(" Select the number of the shape you want to change:\n");
        }
        
        public static void ShowChangeFigureMenu()
        {
            Console.WriteLine("\n Choose one option:\n");
            Console.WriteLine(" 1. Move");
            Console.WriteLine(" 2. Rotate");
            Console.WriteLine(" 3. Scale");
            Console.WriteLine("\n 0. Back to Main Menu.\n");
        }
    }
}
