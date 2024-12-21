using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmw19._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Palindrome.IsPalindrome(number));
        }
    }
}