using System;
using System.Linq;

namespace Sort_and_Star
{
    /*
     You will be given a vector of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.

    The returned value must be a string, and have "***" between each of its letters.

    You should not remove or add elements from/to the array.
     */

    
    }

    class Program
    {
    public static string TwoSort(string[] s) {
        Array.Sort(s, StringComparer.Ordinal);
        return string.Join("***", s.First().ToArray());
    }
    
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }

