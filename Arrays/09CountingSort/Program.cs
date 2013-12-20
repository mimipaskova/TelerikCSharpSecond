using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int[] counting = new int[10];

            //pulnim vtoriq masiv s 0
            for (int i = 0; i < counting.Length; i++)
            {
                counting[i] = 0;
            }

            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < counting.Length; j++)
                {
                    if(masiv[i]==j)
                    {
                        counting[j]++;
                    }
                }
            }

            int max = counting[0];
            int value = 0;
            for (int i = 0; i < counting.Length; i++)
            {
                if (counting[i] > max)
                {
                    max = counting[i];
                    value = i;
                }
            }
            Console.WriteLine(value + " " + max + " times");

        }
    }
}
