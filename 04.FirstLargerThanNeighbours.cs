using System;
using System.Globalization;
using System.Linq;
using System.Threading;

/// <summary>
/// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if 
/// there's no such element. Use the method from the previous exercise in order to re.
/// </summary>

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(array));
    }

    private static int GetIndexOfFirstElementLargerThenNeighbours(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            if (IsLargerThanNeighbours(array, i))
            {
                return i;
            }
        }
        return -1;
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
            isLarger = (array[i] > array[i + 1]);
        }
        return isLarger;
    }
}
