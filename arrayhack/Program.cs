using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int arrItem = 0;

        for (int i = 0; i < n; i++)
        {
            arrItem = Convert.ToInt32(Console.ReadLine());
            arr[i] = arrItem;
        }

        printRev(arr);
    }

    static void printRev(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr.Reverse()));
        Console.Read();
    }
}