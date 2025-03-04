﻿using System;

namespace ConsoleApplication1 {
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(AvgValue(arr));
        }

        private static double AvgValue(int[] arr)
        {
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double) sum / arr.Length;
        }

        private static int MaxValue(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("Array is empty");
            }

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                var current = arr[i];
                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }
    }
}