//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
namespace DivideBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainDivide
    {

        static void Main()
        {
            var numbers = new[] { 1, 2, 5, 4, 21, 12, 7 };

            var dividedNumbers = numbers
                                .Where(n => n % 3 == 0 && n % 7 == 0);

            //var dividedNumbers = from n in numbers
            //                     where n % 3 == 0 && n % 7 == 0
            //                     select n;

            foreach (var number in dividedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
