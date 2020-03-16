using FAC.Common.Models;

namespace FAC.Helper
{
    public static class TriangleHelper
    {
        public static bool IsRightTriangle(Triangle triangle)
        {
            if ((triangle.SideA * triangle.SideA == triangle.SideB * triangle.SideB + triangle.SideC * triangle.SideC) 
                || (triangle.SideB * triangle.SideB == triangle.SideA * triangle.SideA + triangle.SideC * triangle.SideC) 
                || (triangle.SideC * triangle.SideC == triangle.SideB * triangle.SideB + triangle.SideA * triangle.SideA))
            {
                return true;
            }
            return false;
        }

        public static (double, double) GetTheLongestSide(Triangle triangle)
        {
            return triangle.SideA > triangle.SideB && triangle.SideA > triangle.SideC
                ? (a: triangle.SideB, b: triangle.SideC)
                : triangle.SideB > triangle.SideC
                    ? (a: triangle.SideA, b: triangle.SideC)
                    : (a: triangle.SideA, b: triangle.SideB);
        }
    }
}
