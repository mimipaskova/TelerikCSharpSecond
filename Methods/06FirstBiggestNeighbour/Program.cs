using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FirstBiggestNeighbour
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstBiggest numberOne = new FirstBiggest();
            int[] array = new int[] { 1, 2, 4,43,55, 22, 4, 2, 4, 2, 4, 21 };
            Console.WriteLine(numberOne.FirstBiggestNum(array));
        }
    }
}
