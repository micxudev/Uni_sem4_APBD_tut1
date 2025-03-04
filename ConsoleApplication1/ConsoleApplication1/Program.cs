using System;

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
    }
}