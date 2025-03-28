using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default Detail of car:");
            Car car1 = new Car();
            car1.Display();
            Console.WriteLine("Original Detail of car:");
            Car car2 = new Car("Camry","Toyota",2024,120);
            car2.Display();

            //Deep copy
            Car car3 = new Car(car2);
            Console.WriteLine("Now we increase its speed by 25 km/h.");
            car3.Car_Acceleration(25);
            car3.Display();
        }
    }
}
