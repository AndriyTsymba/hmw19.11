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

            Console.WriteLine("Введіть довжину сторони квадрата:");
            int line = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть символ для виведення:");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Виведення квадрата:");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}

