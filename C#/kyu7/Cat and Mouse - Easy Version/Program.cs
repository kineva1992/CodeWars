using System;
using System.Linq;

namespace Cat_and_Mouse___Easy_Version
{
    class Program
    {
        public static string CatMouse(string x) {
            int start;
            start = x.Length;

            return start - 2 > 3 ? "Escaped!" : "Caught!";
        }

        public static string CatMouseVer2(string x) => x.Count(c => c == '.') > 3 ? "Escaped!" : "Caught!";

        public static string CatMouseVer3(string x) {
            int count;

            count = 0;
            foreach (char item in x) {
                if (item == '.') {
                    count++;
                }
            }

            return count < 3 ? "Caught!" : "Escaped!";

        }


        static void Main(string[] args)
        {
            
        }
    }
}
