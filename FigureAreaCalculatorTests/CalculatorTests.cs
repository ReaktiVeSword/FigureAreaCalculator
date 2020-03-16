using FAC.Interfaces;
using FigureAreaCalculator;
using NUnit.Framework;

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

        [TestCase(4,2,3, 2.9047375096555625)]
        public void CalculatorTriangleArea_ThreeSidesGiven_RightAreaCalculation(double a, double b, double c, double answer)
        {
            var result = _calculator.CalculatorTriangleArea(a, b, c);
            Assert.AreEqual(answer, result);
        }

        [Test]
        public void CalculateCircleArea_RadiusGiven_RightAreaCalculation()
        {
            var result = _calculator.CalculateCircleArea(4);
            Assert.AreEqual(50.26548245743669, result);
        }
    }
}