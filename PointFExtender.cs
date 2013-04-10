using System;
using System.Drawing;

namespace OrthogonalLinearRegression
{
    public static class PointFExtender
    {
        /// <summary>
        /// Calculate the distance between two points
        /// </summary>
        /// <param name="point1">First point</param>
        /// <param name="point2">Second point</param>
        /// <returns>Distance between the points</returns>
        public static float Distance(this PointF point1, PointF point2)
        {
            float distance = (float)Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) +
                                              (point2.Y - point1.Y) * (point2.Y - point1.Y));
            return distance;
        }
    }
}
