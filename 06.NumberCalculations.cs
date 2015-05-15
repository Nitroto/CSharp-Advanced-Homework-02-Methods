using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

/// Write methods to calculate the minimum, maximum, average, sum and product of a given set 
/// of numbers. Overload the methods to work with numbers of type double and decimal.

class NumberCalculations
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("For double press 1 or for decimal press 2");
        int user = int.Parse(Console.ReadLine());
        List<double> doubleNumber = new List<double>();
        List<decimal> decimalNumber = new List<decimal>();
        switch (user)
        {
            case 1: doubleNumber = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToList(); break;
            case 2: decimalNumber = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => decimal.Parse(x)).ToList(); break;
            default: Console.WriteLine("Wrong selection!"); break;
        }
        Console.WriteLine("1. Minimum\n\r2. Maximim\n\r3. Average\n\r4. Sum\n\r5. Product");
        int action = int.Parse(Console.ReadLine());
        if (user == 1)
        {
            switch (action)
            {
                case 1: GetMinimum(doubleNumber); break;
                case 2: GetMaximum(doubleNumber); break;
                case 3: GetAverage(doubleNumber); break;
                case 4: GetSum(doubleNumber); break;
                case 5: GetProduct(doubleNumber); break;
            }
        }
        else
        {
            switch (action)
            {
                case 1: GetMinimum(decimalNumber); break;
                case 2: GetMaximum(decimalNumber); break;
                case 3: GetAverage(decimalNumber); break;
                case 4: GetSum(decimalNumber); break;
                case 5: GetProduct(decimalNumber); break;
            }
        }
    }

    private static void GetMinimum(List<double> list)
    {
        Console.WriteLine("Minimum: {0}", list.Min());
    }
    private static void GetMinimum(List<decimal> list)
    {
        Console.WriteLine("Minimum: {0}", list.Min());
    }
    private static void GetMaximum(List<double> list)
    {
        Console.WriteLine("Maximum: {0}", list.Max());
    }
    private static void GetMaximum(List<decimal> list)
    {
        Console.WriteLine("Maximum: {0}", list.Max());
    }
    private static void GetAverage(List<double> list)
    {
        Console.WriteLine("Average: {0}", list.Average());
    }
    private static void GetAverage(List<decimal> list)
    {
        Console.WriteLine("Average: {0}", list.Average());
    }
    private static void GetSum(List<double> list)
    {
        Console.WriteLine("Sum: {0}", list.Sum());
    }
    private static void GetSum(List<decimal> list)
    {
        Console.WriteLine("Sum: {0}", list.Sum());
    }
    private static void GetProduct(List<double> list)
    {
        double product = 1;
        foreach (var number in list)
        {
            product *= number;
        }
        Console.WriteLine("Product: {0}", product);
    }
    private static void GetProduct(List<decimal> list)
    {
        decimal product = 1;
        foreach (var number in list)
        {
            product *= number;
        }
        Console.WriteLine("Product: {0}", product);
    }
}