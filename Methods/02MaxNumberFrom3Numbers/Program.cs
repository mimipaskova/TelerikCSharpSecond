using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MaxNumberFrom3Numbers
{
    class Program
    {
        static int GetMax(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
                return numberOne;
            else
                return numberTwo;
        }

        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int max = GetMax(GetMax(numberOne, numberTwo), numberThree);
            Console.WriteLine(max);
        }
    }
}
