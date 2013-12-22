using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SequenceMaxSumWithSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int S = int.Parse(Console.ReadLine());

            int sum = array[0], max_ending_here = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max_ending_here < 0 || S==array[i])
                {
                    max_ending_here = array[i];
                }
                else 
                {
                    max_ending_here += array[i];
                }

                if (
                    //max_ending_here >= sum &&
                    S == max_ending_here)
                {
                    sum = max_ending_here;

                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
