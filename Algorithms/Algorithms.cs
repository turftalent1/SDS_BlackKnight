using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            int factorial = 1;
            for (var i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static string FormatSeparators(params string[] items)
        {
            if(items.Count() >= 2) 
            {
                return $"{string.Join(", ", items, 0, items.Count() - 1)} and {items.Last()}";
            }
            else
            {
                return $"{items.Last()}";
            }
        }
    }
}