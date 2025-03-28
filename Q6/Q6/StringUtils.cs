using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal static class StringUtils
    {
        public static void Reverse(char[] Text) 
        {
            for (int i = Text.Length-1; i>=0; i--)
            {
                Console.Write(Text[i]);
            }
        }
        public static void  Length(char[] Text)
        {
            int i;
            for ( i = 0; i < Text.Length; i++)
            {
          
            }
            Console.WriteLine($"\nTotal characters in Text is {i}");
        }
        /* other approach of characters counting
         public static int Length1(string a)
         {
             return a.Length;
         }*/
        public static string upper(string Text)
        {
            return Text.ToUpper();
        }
    }
}
