//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average
namespace IEnumerable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Extensions;

    public class TestMainIEnum
    {
        static void Main()
        {
            IEnumerable<double> numbers = new double[] { 2.1, 4.2, 5.2, 2.5 };

            Console.WriteLine("Collection : ");
            foreach (var element in numbers)
            {
                Console.WriteLine("{0}",element);
            }
            Console.WriteLine();
            Console.WriteLine("The sum of all numbers is : {0}", numbers.Sum());
            Console.WriteLine("The product of all numbers is : {0}", numbers.Product());
            Console.WriteLine("The min of all numbers is : {0}", numbers.Min());
            Console.WriteLine("The max of all numbers is : {0}", numbers.Max());
            Console.WriteLine("The average of all numbers is : {0}", numbers.Average());
            Console.WriteLine();

        }
    }
}
