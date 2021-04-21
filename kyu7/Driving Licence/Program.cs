using System;

namespace Driving_Licence
{
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
