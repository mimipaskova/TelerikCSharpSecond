using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Reversing ReverseClass = new Reversing();
            int number = int.Parse(Console.ReadLine());
            ReverseClass.Reverse(number);
        }
    }
}
