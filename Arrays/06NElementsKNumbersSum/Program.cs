using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06NElementsKNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] masiv = new int[N];
            Console.WriteLine("Enter the array");

            for (int i = 0; i < N; i++)
            {
                masiv[i] = int.Parse(Console.ReadLine());                
            }

            int sum = int.MinValue;
            int maxSum=sum;
            int[] numbers = new int[K];

            for (int i = 0; i < N-K; i++)
            {
                for (int j = i; j < i+K; j++)
                {
                    sum += masiv[j];                    
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    sum = 0;
                    for (int k = i; k < K+i; k++)
                    {
                        numbers[k-i] = masiv[k];
                    }                    
                }
                else
                {
                    sum = 0;
                }
            }
            Console.WriteLine("Max sum is {0}",maxSum);
            for (int i = 0; i < K; i++)
            {
                Console.WriteLine(numbers[i]);
            }


        }
    }
}
