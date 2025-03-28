using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t----Mathematics Implementation---\n");
            Console.WriteLine($"->Addition = {MathUtils.Add(10, 500)}");
            Console.WriteLine($"->Subtraction = {MathUtils.Subtract(1000, 500)}");

            Console.WriteLine($"->Multiplication = {MathUtils.Multiply(10, 500)}");

            
            MathUtils.Divide(10000, 5);



        }
    }
}
