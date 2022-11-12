using System;
using FigureCreatorApp.Menu;
using FigureCreatorApp.Figures;
using FigureCreatorApp.Mangers;
using System.Collections.Generic;

namespace FigureCreatorApp.Factories
{
    public abstract class FigureCreator
    {
        public abstract Figure CreateFigure();

        public abstract Figure CreateFigure(List<Point> points);

        public static FigureCreator SelectFigure()
        {
            FigureCreator figureCreator = new SquareCreator();

            int option = InputManager.ChooseOption(0, 5);
            switch (option)
            {
                case 1:
                    figureCreator = new SquareCreator();
                    break;

                case 2:
                    figureCreator = new SquareCreator();
                    break;

                case 3:
                    figureCreator = new TriangleCreator();
                    break;
                case 4:
                    figureCreator = new CircleCreator();
                    break;                
                case 0:
                    MenuLogic.MainMenu();
                    break;

                default:
                    return SelectFigure();
            }

            return figureCreator;
        }
    }
}
