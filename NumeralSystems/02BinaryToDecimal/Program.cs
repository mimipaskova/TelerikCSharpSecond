using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double[] resultOne=new double[10];
            double result = 0;

            int i = 0;
            while(number!=0)
            {
                result += (number % 10) * Math.Pow(2, i);
                number = number / 10;
                i++;

            }

            Console.WriteLine(result);
        }
    }
}
