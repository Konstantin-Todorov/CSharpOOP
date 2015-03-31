﻿
//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace RangeException
{
    using RangeException.Exception;
    using System;
    using System.Globalization;

    public class RangeExceptionMain
    {
        public static void Main()
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter numbers from 1 to 100 : ");
                    int number = int.Parse(Console.ReadLine());

                    if (number < 1 || number > 100)
                    {
                        throw new InvalidRangeException<int>("Invalid number!", 1, 100);
                    }
                    else
                    {
                        Console.WriteLine("You entered a correct number !");
                    }
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                while (true)
                {
                    Console.Write("Enter a date in format [yyyy mm dd] : ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    if (date.CompareTo(new DateTime(1980, 1, 1)) < 0 || date.CompareTo(new DateTime(2013, 12, 31)) > 0)
                    {
                        throw new InvalidRangeException<DateTime>("Invalid date!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                    }
                    else
                    {
                        Console.WriteLine("You entered a correct date !");
                    }
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
