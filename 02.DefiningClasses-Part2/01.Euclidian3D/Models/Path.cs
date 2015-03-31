﻿namespace _01.Euclidian3D.Models
{
    using  System.Collections.Generic;
    using System.Collections;
    public class Path : IEnumerable<Point3D>
    {
        private ICollection<Point3D> points;

        public Path()
        {
            this.points = new HashSet<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
