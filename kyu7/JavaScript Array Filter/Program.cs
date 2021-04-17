using System;
using System.Collections.Generic;
using System.Linq;

namespace JavaScript_Array_Filter
{
    class Program
    {
        /*Starting with .NET Framework 3.5, C# supports a Where (in the System.Linq namespace) 
         * method which allows a user to filter arrays based on a predicate. 
         * Use the Where method to complete the function given.*/
        public static int[] GetEvenNumbers(int[] numbers)
        {
            List<int> newNumber = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 1) == 0) {

                    newNumber.Add(numbers[i]);
                }

            }
            return newNumber.ToArray();
        }

        public static int[] GetEvenNumbersVer2(int[] numbers) => numbers.Where(n => n % 2 == 0).ToArray();
        

        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,11,1,1,2};



            Console.WriteLine(GetEvenNumbersVer2(numbers));
        }
    }
}
