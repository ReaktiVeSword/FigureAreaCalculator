using System;
using System.Collections.Generic;
using System.Text;

namespace FAC.Interfaces
{
    public interface ICalculator
    {
        double CalculateCircleArea(double radius);
        double CalculatorTriangleArea(double side1, double side2, double side3);
    }
}
