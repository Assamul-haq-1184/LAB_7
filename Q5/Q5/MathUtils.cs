using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal static class MathUtils
    {
        public static double Add(double A, double B) 
        { 
        return A + B;
        }
        public static double Subtract(double A, double B)
        { return A - B;
        }
        public static double Multiply(double A, double B) {return A * B; }
        public static void Divide(double A, double B)
        {
            if (A == 0) { Console.WriteLine($"You enter denominator zero which is not possible"); }
            else { Console.WriteLine($"->Division = {A / B}"); }
        }


    }
}
