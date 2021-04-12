using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLight
{
    class FunctionalClass
    {
        public static string UpdateLight(string current)
        {
            return current == "yellow" ? "red" : current == "green" ? "yellow" : "green";
        }

        public static string UpdateLightV2(string current)
        {
            string result;

            switch (current) {
                case "green": result = "yellow"; break;
                case "yellow": result = "red"; break;
                case "red": result = "green"; break;
                default:
                    throw new ArgumentException($"{nameof(current)} is not valid traffic light state");
            }

            return result;
        }
    }
}
