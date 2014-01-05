using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BiggestNeighbour
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BiggestNumber array = new BiggestNumber();
            int[] myArray = new[] { 1,2 };
            int position = int.Parse(Console.ReadLine());
           Console.WriteLine(array.BiggestNeighbour(myArray, position));
            

        }
    }
}
