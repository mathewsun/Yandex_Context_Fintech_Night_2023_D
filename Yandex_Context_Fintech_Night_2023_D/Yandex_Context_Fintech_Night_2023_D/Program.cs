using System;
using System.Collections.Generic;
using System.Linq;

namespace Yandex_Task_D
{
    internal class Program
    {
        static int SolveTask()
        {
            var arr = Console.ReadLine().Split(' ').
                      Select(x => Convert.ToInt32(x)).
                      ToArray();
            int n = arr[0];
            int q = arr[1];

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < q; i++)
            {
                var newLine = Console.ReadLine().Split(' ').
                      Select(x => Convert.ToInt32(x)).
                      ToArray();
                if (dict.ContainsKey(newLine[0]))
                {
                    dict[newLine[0]]++;
                }
                else
                {
                    dict[newLine[0]] = 1;
                }
            }

            int min = n;
            foreach (var c in dict.Keys.OrderBy(x => x))
            {
                if (dict[c] == 3)
                {
                    min = Math.Min(c - 1, min);
                }
            }

            return min;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(SolveTask());
            }
        }
    }
}