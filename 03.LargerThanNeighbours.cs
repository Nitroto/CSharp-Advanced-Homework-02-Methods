using System;
using System.Globalization;
using System.Linq;
using System.Threading;

/// Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours (when such exist)

class LargerThanNeighbours
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(array, i));
        }
    }

    private static bool IsLargerThanNeighbours(int[] array, int i)
    {
        bool isLarger = false;
        if (i > 0)
        {
            if (i < array.Length - 1)
            {
                isLarger = (array[i] > array[i - 1] && array[i] > array[i + 1]);
            }
            else
            {
                isLarger = (array[i] > array[i - 1]);
            }
        }
        else
        {
            isLarger = (array[i]>array[i+1]);
        }
        return isLarger;
    }
}
