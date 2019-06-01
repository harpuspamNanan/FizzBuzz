using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string str , str1 ="";
            char[] ch= new char[100];

            Console.WriteLine("Enter a Text - ");
            str = Console.ReadLine();



            for (int i = str.Length; i > 0; i--)
            {
                str1 = str1+ch[i];
                Console.WriteLine(str1);
            }
            if (str1.Equals(str))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
            Console.ReadLine();
        }
    }
}
