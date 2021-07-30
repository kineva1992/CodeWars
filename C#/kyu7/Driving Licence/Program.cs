using System;

namespace Driving_Licence
{

    /*
     Task
The UK driving number is made up from the personal details of the driver. The individual letters and digits can be code using the below information

    Rules
1–5: The first five characters of the surname (padded with 9s if less than 5 characters)

6: The decade digit from the year of birth (e.g. for 1987 it would be 8)

7–8: The month of birth (7th character incremented by 5 if driver is female i.e. 51–62 instead of 01–12)

9–10: The date within the month of birth

11: The year digit from the year of birth (e.g. for 1987 it would be 7)

12–13: The first two initials of the first name and middle name, padded with a 9 if no middle name

14: Arbitrary digit – usually 9, but decremented to differentiate drivers with the first 13 characters in common. We will always use 9

15–16: Two computer check digits. We will always use "AA"
     */
    class Program
    {
        public string driver(params string[] data)
        {
            string date = DateTime.Parse(data[3]).ToString("ddMMyyyy");
            return data[2].PadRight(5, '9').Substring(0, 5).ToUpper() + data[6] + ((data[4] == "F") ? (date[2] - 43).ToString() + date[3] : date.Substring(2, 2)) + date.Substring(0, 2)
                + date[7] + data[0][0] + ((data[1].Length != 0) ? data[0][1] : '9') + "9AA";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
