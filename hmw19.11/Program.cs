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

            Website website = new Website("Google", "google.com", "Search engine", "fdfdfdfd");
            Console.WriteLine(website.Print());
        }
    }
}