using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Counter
    {
        private static int count = 0;
        public static int Get_Count { get { return count; } }

        private static void Increment()
        {
            count++;
        }
        public Counter() 
        { 
          Increment();  
        }
    }
}
