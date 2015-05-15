using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// Write a method which takes an array of any type and sorts it. Use bubble sort or selection sort (your own implementation). 
/// You may re-use your code from a previous homework and modify it. 
/// Use a generic method(read in Internet about generic methods in C#). Make sure that what you're trying to sort can be sorted – 
/// your method should work with numbers, strings, dates, etc., but not necessarily with custom classes like Student.

class GenericArraySort
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("For integer press 1, for string press 2, for DateTime press 3");
        int user = int.Parse(Console.ReadLine());
        switch (user)
            {
            case 1: SortArray(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray()); break;
            case 2: SortArray(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray()); break;
            case 3: SortArray(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => DateTime.Parse(x)).ToArray());; break;
        }
        Console.WriteLine();
    }
    public static void SortArray<T>(T[] source)
    {
        int counter = 0;
        var sorted = source.ToArray();
        do
        {
            counter = 0;
            for (int i = 0; i < sorted.Length - 1; i++)
            {
                var bubble = sorted[i];
                if (Comparer<T>.Default.Compare(sorted[i], sorted[i + 1]) > 0)
                {
                    sorted[i] = sorted[i + 1];
                    sorted[i + 1] = bubble;
                    counter++;
                }
            }
        } while (counter != 0);
        foreach (var element in sorted)
        {
            Console.Write("{0} ", element);
        }
    }
}
