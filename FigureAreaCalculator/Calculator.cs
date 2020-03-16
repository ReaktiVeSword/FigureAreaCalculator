using FAC.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculator
{
    public class Calculator : ICalculator
    {
        public readonly double PI = Math.PI;

        public double CalculateCircleArea(double radius)
        {
            return PI * radius * radius;
        }

        public double CalculatorTriangleArea(double side1, double side2, double side3)
        {
            var halfPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        }
    }
}
