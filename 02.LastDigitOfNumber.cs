using System;
using System.Globalization;
using System.Threading;

/// Write a method that returns the last digit of a given integer as an English word. Test the method with 
/// different input values. Ensure you name the method properly.

class LastDigitOfNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitAsWord(n));
        }
    }

    private static string GetLastDigitAsWord(int n)
    {
        int lastDigit = n % 10;
        string word = string.Empty;
        switch (lastDigit)
        {
            case 0: word = "zero";break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
        }
        return word;
    }
}
