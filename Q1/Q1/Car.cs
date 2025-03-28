using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Car
    {
        public string Model;
        public string Make;
        public int Year_of_manufacturer;
        public double Current_Speed;

        //Basic constructor
        public Car(string model, string make, int year, double speed)
        {
            Model = model;
            Make = make;
            Year_of_manufacturer = year;
            Current_Speed = speed;
        }
        //Parameterless constructor
        public Car() : this("Generic", "Unknown", 2025, 0) { }

        public Car(Car other)
        {
            Model = other.Model;
            Make = other.Make;
            Year_of_manufacturer = other.Year_of_manufacturer;
            Current_Speed = other.Current_Speed;
        }
        public void Car_Acceleration(int Increase)
        {
            Current_Speed += Increase;
            Console.WriteLine();
        }
        public string Car_Make {  
            get { return Model; } 
            set { Model = value; }
        }
        public string Car_Model
        {
            get { return Model; }
            set { Model = value; }
        }
        public int Car_year
        {
            get { return Year_of_manufacturer; }
            set {  Year_of_manufacturer = value; }
        }
        public double Car_speed
        {
            get { return Current_Speed; }
            set { Current_Speed = value; }
        }
         
        //Display
        public void Display()
        {
            Console.WriteLine($"Brand : {Make},\t       Model : {Model}\nYear of Manufacturer : {Year_of_manufacturer},   Speed : {Current_Speed} KM \n");

        }

        
            
        
    }
}
