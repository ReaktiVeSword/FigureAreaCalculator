using FAC.Common.Models;
using FAC.Helper;
using FAC.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
                    return null;
            }
        }

        public double CalculateCircleArea(Circle circle)
        {
            return PI * circle.Radius * circle.Radius;
        }

        public double CalculateTriangleArea(Triangle triangle)
        {
            if (TriangleHelper.IsRightTriangle(triangle))
            {
                var sides = TriangleHelper.GetTheLongestSide(triangle);
                return CalculateRightTriangleArea(sides.Item1, sides.Item2);
            }
            return CalculateSimpleTriangleAreaByThreeSides(triangle);
        }

        private double CalculateSimpleTriangleAreaByThreeSides(Triangle triangle)
        {
            var halfPerimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - triangle.SideA) * (halfPerimeter - triangle.SideB) * (halfPerimeter - triangle.SideC));
        }

        private double CalculateRightTriangleArea(double side1, double side2)
        {
            return (side1 * side2) / 2;
        }
    }
}
