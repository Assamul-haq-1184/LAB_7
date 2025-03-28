using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringUtils.Reverse("Ali".ToCharArray());
            StringUtils.Length("Ali Raza".ToCharArray());
            Console.WriteLine(StringUtils.upper("ali raza"));
        }
    }
}
