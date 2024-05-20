using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double f)
        {
            var c = (f - 32) / 1.8;
            return c;

        }

        public static double CelsiusToFahrenhiet(double c) 
        {
            return (c * 9) / 5 + 32;
        }

            
    }
}
