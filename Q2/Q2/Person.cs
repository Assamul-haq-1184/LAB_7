using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Person
    {
        private string name;
        private int age;
        private string Address;

        public string Set_Get_name
        {
            get { return name; }
            set { name = value; }
        }
        public int Set_Get_age
        {
            get { return age; }
            set { age = value; }
        }
        public string Set_Get_Address
        {
            get { return Address; }
            set { Address = value; }
        }
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            Address = address;
        }
        public Person() : this("Unknown", 0, "") { }

        public Person(Person other)
        {
            this.name = other.name;
            this.age = other.age;
            this.Address = other.Address;
        }
        public void Address_Change(string address)
        {
           
            Address = address;
            Console.WriteLine($"New address of {name} is {Address}\n");
        }
        public void Display_Detail()
        {
            
            Console.WriteLine($"Name    : {name}");
            Console.WriteLine($"Age     : {age}");
            Console.WriteLine($"Address : {Address}");
        }
    }
}
