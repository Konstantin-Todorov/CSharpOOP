namespace IEnumerable.Extensions
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) //where T : IConvertible , IComparable
        {
            T sum = collection.FirstOrDefault();

            foreach (var element in collection)
            {
                sum += (dynamic)element;
            }

            return sum;
        }

        public static T Product <T>(this IEnumerable<T> collection) //where T : IConvertible , IComparable 
        {
            T product = collection.FirstOrDefault();

            foreach (var element in collection)
            {
                product *= (dynamic)element;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable 
        {
            T min = collection.First();

            foreach (var element in collection)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.First();

            foreach (var element in collection)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            T result = collection.FirstOrDefault();
            int count = 1;

            foreach (var element in collection)
            {
                result += (dynamic)element;
                count++;
            }
            dynamic average = (dynamic)result / count;
            return average;
        }
    }
}











