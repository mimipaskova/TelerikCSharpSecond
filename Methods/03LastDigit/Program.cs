using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LastDigit
{
    class Program
    {
        static int LastDigit(int number)
        {
            int last = number % 10;
            return last;

        }

        static void LastDigitLetter(int number)
        {
            switch (LastDigit(number))
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 0:
                    Console.WriteLine("Zero");
                    break;
            }           
        }

        static void Main(string[] args)
        {
            int numnerOne = int.Parse(Console.ReadLine());
            LastDigitLetter(numnerOne);
        }
    }
}
