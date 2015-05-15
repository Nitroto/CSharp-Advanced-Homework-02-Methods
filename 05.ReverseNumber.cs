using System;
using System.Globalization;
using System.Threading;

/// Write a method that reverses the digits of a given floating-point number

class ReverseNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string userInput = Console.ReadLine();
        double reversed = GetReversedNumber(userInput);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(string input)
    {
        string output = string.Empty;
        double number = double.Parse(input);
        if (number < 0)
        {
            output += "-";
            number *= -1;
        }
        for (int i = number.ToString().Length - 1; i >= 0; i--)
        {
            output += number.ToString()[i];
        }
        return double.Parse(output);
    }
}
