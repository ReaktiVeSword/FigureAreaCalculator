using FAC.Common.Models;

namespace FAC.Common.Extensions
{
    public static class TriangleExtension
    {
        /// <summary>
        /// Is the triangle right
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static bool IsRightTriangle(this Triangle triangle)
        {
            if ((triangle.SideA * triangle.SideA == triangle.SideB * triangle.SideB + triangle.SideC * triangle.SideC)
                || (triangle.SideB * triangle.SideB == triangle.SideA * triangle.SideA + triangle.SideC * triangle.SideC)
                || (triangle.SideC * triangle.SideC == triangle.SideB * triangle.SideB + triangle.SideA * triangle.SideA))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get two cathetuses of triangle
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static (double, double) GetShortSides(this Triangle triangle)
        {
            return triangle.SideA > triangle.SideB && triangle.SideA > triangle.SideC
                ? (a: triangle.SideB, b: triangle.SideC)
                : triangle.SideB > triangle.SideC
                    ? (a: triangle.SideA, b: triangle.SideC)
                    : (a: triangle.SideA, b: triangle.SideB);
        }

        /// <summary>
        /// Is it a triangle
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static bool IsTriangle(this Triangle triangle)
        {
            return triangle.SideA < triangle.SideB + triangle.SideC
                   && triangle.SideB < triangle.SideA + triangle.SideC
                   && triangle.SideC < triangle.SideA + triangle.SideB
                        ? true
                        : false;
        }
    }
}
