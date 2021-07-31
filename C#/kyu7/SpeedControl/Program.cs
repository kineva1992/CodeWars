using System;
using System.Linq;

namespace SpeedControl
{
    public class GpsSpeed
    {
        public static int Gps(int s, double[] x)
        {
            if (x.Length < 2) return 0;
            double[] dx = new double[x.Length];
            dx[0] = (x[0] - 0) / s * 3600;
            for (int i = 1; i < x.Length; i++)
            {
                dx[i] = (x[i] - x[i - 1]) / s * 3600;
            }

            return (int)Math.Floor(dx.Max());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
