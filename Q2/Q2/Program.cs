using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Default values Detail:  ");
            Person P1 = new Person();
            P1.Display_Detail();
            Console.WriteLine("\t\t\t--------------------------------------------------------");
            Console.WriteLine("Original detail of person: ");
            Person P2= new Person("Assamul Haq",19,"55 GB");
            P2.Display_Detail();
            Console.WriteLine("\t\t\t--------------------------------------------------------");
            Console.WriteLine("Now Change the address of the person: ");
            Person P3 = new Person(P2);
            P3.Address_Change("Bilal Garden");
            P3.Display_Detail();    
        }
    }
}
