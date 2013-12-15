using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] masiv = new int[]{5,2,1,4,2,11,345,25,7,9,3};
            int min=int.MaxValue;
            int position = 0;
            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = i; j < masiv.Length; j++)
                {
                    if (masiv[j] < min)
                    {
                        min = masiv[j];
                        position = j;
                    }                   
                }
                masiv[position] = masiv[i];
                masiv[i] = min;
                min = int.MaxValue;
               
            }

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.WriteLine(masiv[i]);   
            }

        }
    }
}
