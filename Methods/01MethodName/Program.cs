using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01MethodName
{
    class Program
    {
        static void PrintName(string Name)
        {
            Console.WriteLine("Hello" + " " + Name);
        }

        static void Main(string[] args)
        {
            string Name=Console.ReadLine();
            PrintName(Name);
        }
    }
}
