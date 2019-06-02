using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//https://www.c-sharpcorner.com/forums/bubble-sort-c-sharp
namespace IT481_Unit7
{
    class Program
    {
        static Random rand = new Random();

        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            // create an array of ? integers 
            int[] a = new int[10];
            for (int i = 0; i < 10; i++) a[i] = rand.Next(10);
            int numComps;
            int numSwaps;

            Console.Clear();

            Console.WriteLine("Results for randomly sorted array\n");
            BubbleSort(a, out numComps, out numSwaps);
            PrintResults(numComps, numSwaps);

            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}ms", stopwatch.Elapsed);
            Console.ReadKey();
        }

        static void BubbleSort(int[] a, out int numComps, out int numSwaps)
        {
            numComps = 0;
            numSwaps = 0;
            int n = a.Length;

            do
            {
                int newN = 0;
                for (int i = 1; i < n; i++)
                {
                    numComps++;
                    if (a[i - 1] > a[i])
                    {
                        numSwaps++;
                        int temp = a[i - 1];
                        a[i - 1] = a[i];
                        a[i] = temp;
                        newN = i;
                    }
                }

                n = newN;
            }
            while (n > 0);
        }

        static void PrintResults(int numComps, int numSwaps)
        {
            Console.WriteLine("Number of comparisons = {0}", numComps);
            Console.WriteLine("Number of swaps = {0}", numSwaps);
            Console.WriteLine();
        }

    }
}
