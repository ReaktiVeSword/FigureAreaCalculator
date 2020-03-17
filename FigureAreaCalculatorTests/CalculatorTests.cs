using FAC.Common.Models;
using FAC.Interfaces;
using FigureAreaCalculator;
using NUnit.Framework;
using System;

namespace FigureAreaCalculatorTests
{
    public class CalculatorTests
    {
        private ICalculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestCase(4, 2, 3, 2.9047375096555625)]
        [TestCase(3, 4, 5, 6)]
        public void CalculateTriangleArea_ThreeSidesGiven_RightAreaCalculation(double a, double b, double c, double answer)
        {
            var triangle = new Triangle { SideA = a, SideB = b, SideC = c };
            var result = _calculator.CalculateTriangleArea(triangle);
            Assert.AreEqual(answer, result);
        }

        [Test]
        public void CalculateCircleArea_RadiusGiven_RightAreaCalculation()
        {
            var result = _calculator.CalculateCircleArea(new Circle { Radius = 4});
            Assert.AreEqual(50.26548245743669, result);
        }

        [Test]
        public void CalculateFigureArea_CircleGiven_RightAreaCalculation()
        {
            var result = _calculator.CalculateFigureArea(new Circle { Radius = 4 });
            Assert.AreEqual(50.26548245743669, result);
        }

        [Test]
        public void CalculateFigureArea_TriangleGiven_RightAreaCalculation()
        {
            var result = _calculator.CalculateFigureArea(new Triangle { SideA = 3, SideB = 4, SideC = 5 });
            Assert.AreEqual(6, result);
        }

        [Test]
        public void CalculateTriangleArea_ThreeSidesGiven_GetException()
        {
            var triangle = new Triangle { SideA = 50, SideB = 4, SideC = 3 };
            Assert.Throws(Is.TypeOf<Exception>()
                .And
                .Message.EqualTo("It is not a Triangle"),
                () =>
                {
                    _calculator.CalculateTriangleArea(triangle);
                });
        }

        [Test]
        public void CalculateFigureArea_FigureGiven_GetException()
        {
            Assert.Throws(Is.TypeOf<Exception>()
                .And
                .Message.EqualTo("There is no such type of figure"),
                () =>
                {
                    _calculator.CalculateFigureArea(new Figure());
                });
        }
    }
}