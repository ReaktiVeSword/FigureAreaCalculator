using FAC.Common.Models;

namespace FAC.Interfaces
{
    public interface ICalculator
    {
        /// <summary>
        /// Get circle area
        /// </summary>
        /// <param name="circle"></param>
        /// <returns></returns>
        double CalculateCircleArea(Circle circle);

        /// <summary>
        /// Get triangle area
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        double CalculateTriangleArea(Triangle triangle);

        /// <summary>
        /// Get figure area
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        double? CalculateFigureArea(Figure figure);
    }
}
