using FAC.Common.Models;

namespace FAC.Interfaces
{
    public interface ICalculator
    {
        double CalculateCircleArea(Circle circle);
        double CalculateTriangleArea(Triangle triangle);
        double? CalculateFigureArea(Figure figure);
    }
}
