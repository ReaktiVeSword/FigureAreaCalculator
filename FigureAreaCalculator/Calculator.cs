using FAC.Common.Extensions;
using FAC.Common.Models;
using FAC.Interfaces;
using System;

namespace FigureAreaCalculator
{
    public class Calculator : ICalculator
    {
        public readonly double PI = Math.PI;

        public double? CalculateFigureArea(Figure figure)
        {
            switch (figure)
            {
                case Circle c:
                    return CalculateCircleArea(c);
                case Triangle t:
                    return CalculateTriangleArea(t);
                default:
                    throw new Exception("There is no such type of figure");
            }
        }

        public double CalculateCircleArea(Circle circle)
        {
            return PI * circle.Radius * circle.Radius;
        }

        public double CalculateTriangleArea(Triangle triangle)
        {
            if (!triangle.IsTriangle())
            {
                throw new Exception("It is not a Triangle");
            }

            if (triangle.IsRightTriangle())
            {
                var sides = triangle.GetShortSides();
                return CalculateRightTriangleArea(sides.Item1, sides.Item2);
            }
            return CalculateSimpleTriangleAreaByThreeSides(triangle);
        }

        /// <summary>
        /// Calculate triangle area
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        private double CalculateSimpleTriangleAreaByThreeSides(Triangle triangle)
        {
            var halfPerimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - triangle.SideA) * (halfPerimeter - triangle.SideB) * (halfPerimeter - triangle.SideC));
        }

        /// <summary>
        /// Calculate right triangle area
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <returns></returns>
        private double CalculateRightTriangleArea(double side1, double side2)
        {
            return (side1 * side2) / 2;
        }
    }
}
