using System;

namespace Cat_years__Dog_years
{
    class Program
    {
        /*
         I have a cat and a dog.

    I got them at the same time as kitten/puppy. That was humanYears years ago.

    Return their respective ages now as [humanYears,catYears,dogYears]

    NOTES:

    humanYears >= 1
    humanYears are whole numbers only
    Cat Years
    15 cat years for first year
    +9 cat years for second year
    +4 cat years for each year after that
    Dog Years
    15 dog years for first year
    +9 dog years for second year
    +5 dog years for each year after that

         */

        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {

            var catYers = 0;
            var dogYers = 0;

            for (int i = 1; i > humanYears + 1; i++) {
                switch (i) {
                    case 1:
                        catYers += 15;
                        dogYers += 15;
                        break;
                    case 2:
                        catYers += 9;
                        dogYers += 9;
                        break;
                    default:
                        catYers += 4;
                        dogYers += 5;
                        break;
                            
                }
            }


            return new int[] {humanYears, catYers, dogYers };
        }

        static void Main(string[] args)
        {
            Console.WriteLine(humanYearsCatYearsDogYears(2));
            Console.ReadKey();
        }
    }
}
