using FigureCreatorApp.Figures;
using FigureCreatorApp.Mangers;
using Microsoft.AspNetCore.Mvc;

namespace FigureCreatorApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FigureController : ControllerBase
    {
        private readonly ILogger<FigureController> _logger;

        public FigureController(ILogger<FigureController> logger)
        {
            _logger = logger;
        }

        [HttpPut("ResetFigures")]
        public IEnumerable<Figure> ResetFigures()
        {
            FileManager.InitializeDefaultFigures();
            FileManager.SaveToFile();
            return FileManager.GetListOfFiguresFromFile();
        }

        [HttpGet("GetFigures")]
        public IEnumerable<Figure> GetFigures()
        {
            return FileManager.GetListOfFiguresFromFile();
        }

        [HttpGet("GetFigure/{figureId}")]
        public Figure GetFigureWithId(int figureId)
        {
            return FileManager.GetListOfFiguresFromFile().Find(s => s.Id == figureId);
        }

        // Для каждой фигуры такой же метод, только что делать с многоугольником?
        [HttpPost("CreateCicle/{centerCoordX}/{centerCoordY}/{coordOncircleX}/{coordOncircleY}")]
        public IEnumerable<Figure> CreateCicle(double centerCoordX, double centerCoordY, double coordOncircleX, double coordOncircleY)
        {
            if (!FileManager.FigureList.Any())
            {
                FileManager.InitializeFromFile();
            }

            List<Point> points = new List<Point>();

            points.Add(new Point(centerCoordX, centerCoordY));
            points.Add(new Point(coordOncircleX, coordOncircleY));

            FileManager.FigureList.Add(new Circle(points));
            FileManager.SaveToFile();

            return FileManager.GetListOfFiguresFromFile();
        }

        [HttpPatch("MoveFigure/{figureId}")]
        public Figure MoveFigure(int figureId, double coordinateX, double coordinateY)
        {
            if (!FileManager.FigureList.Any())
            {
                FileManager.InitializeFromFile();
            }

            var step = new Point(coordinateX, coordinateY);
            FileManager.FigureList[figureId - 1].Move(step);
            FileManager.SaveToFile();

            return FileManager.FigureList[figureId - 1];
        }

        [HttpPatch("RotateFigure/{figureId}")]
        public Figure RotateFigure(int figureId, double rotationDegree)
        {
            if (!FileManager.FigureList.Any())
            {
                FileManager.InitializeFromFile();
            }

            FileManager.FigureList[figureId - 1].Rotate(rotationDegree);
            FileManager.SaveToFile();

            return FileManager.FigureList[figureId - 1];
        }

        [HttpPatch("ScaleFigure/{figureId}")]
        public Figure ScaleFigure(int figureId, double scaleMultiplayer)
        {
            if (!FileManager.FigureList.Any())
            {
                FileManager.InitializeFromFile();
            }

            FileManager.FigureList[figureId - 1].Scale(scaleMultiplayer);
            FileManager.SaveToFile();

            return FileManager.FigureList[figureId - 1];
        }

        [HttpDelete("DeleteFigure/{figureId}")]
        public IEnumerable<Figure> DeleteWithId(int figureId)
        {

            if (!FileManager.FigureList.Any())
            {
                FileManager.InitializeFromFile();
            }

            FileManager.DeleteFigureFromFile(figureId);

            return FileManager.GetListOfFiguresFromFile();
        }
    }
}