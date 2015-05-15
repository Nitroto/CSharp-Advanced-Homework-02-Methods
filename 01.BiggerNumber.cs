using System;
using System.Globalization;
using System.Threading;

/// Write a method GetMax() with two parameters that returns the larger of two integers. 
/// Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax()

class BiggerNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int max = GetMax(first, second);
        Console.WriteLine("{0}", max);
    }

    private static int GetMax(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}
