using System;
using _01.Euclidian3D.Models;

namespace _01.Euclidian3D.Extensions
{
    public static class Point3DExtensions
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secodPOint)
        {
            double distance = 0.0;
            distance = Math.Sqrt(
                (firstPoint.X - secodPOint.X) * (firstPoint.X - secodPOint.X) +
                (firstPoint.Y - secodPOint.Y) * (firstPoint.Y - secodPOint.Y) +
                (firstPoint.Z - secodPOint.Z) * (firstPoint.Z - secodPOint.Z));

            return distance;
        }
    }
}
