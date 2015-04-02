//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64
{
    using System;

    public class ArrayTesting
    {
        public static void Main()
        {
            var longNum = new BitArray64();

            longNum[12] = 1;
            longNum[53] = 1;
            longNum[19] = 1;
            longNum[22] = 0;

            Console.WriteLine(longNum);
        }
    }
}