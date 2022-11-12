using System;
using FigureCreatorApp.Figures;
using FigureCreatorApp.Mangers;
using FigureCreatorApp.Factories;

namespace FigureCreatorApp.Menu
{
    public static class MenuLogic
    {
        public static void MainMenu()
        {
            MenuUI.ShowMainMenu();
            int option = InputManager.ChooseOption(0, 4);
            switch (option)
            {
                case 1:
                    FileManager.ShowAllUnsavedFigures();
                    MainMenu();
                    break;
                case 2:
                    ChooseFigure();
                    break;
                case 3:
                    ChangeFigure();
                    break;
                case 4:
                    FileManager.SaveToFile();
                    MainMenu();
                    break;
                case 0:
                    FileManager.SaveToFile();
                    Environment.Exit(0);
                    break;
            }
        }

        public static void ChooseFigure()
        {
            MenuUI.ShowCreateFigureMenu();

            FigureCreator figureCreator = FigureCreator.SelectFigure();
            Figure figure = figureCreator.CreateFigure();
            FileManager.FigureList.Add(figure);
            MainMenu();
        }

        public static void ChangeFigure()
        {
            FileManager.ShowAllUnsavedFigures();
            MenuUI.ShowSelectChangeFigureMenu();
            int option = InputManager.ChooseOption(0, FileManager.FigureList.Count);
            if (option == 0)
            {
                MainMenu();
            }
            else
            {
                MenuUI.ShowChangeFigureMenu();
                int op = InputManager.ChooseOption(0, 3);
                switch (op)
                {
                    case 1:
                        FileManager.FigureList[option - 1].Move(InputManager.GetPoint());
                        MainMenu();
                        break;
                    case 2:
                        FileManager.FigureList[option - 1].Rotate(InputManager.GetDoubleInput());
                        MainMenu();
                        break;
                    case 3:
                        FileManager.FigureList[option - 1].Scale(InputManager.GetDoubleInput());
                        MainMenu();
                        break;
                    case 0:
                        MainMenu();
                        break;
                }
            }
        }
    }
}
