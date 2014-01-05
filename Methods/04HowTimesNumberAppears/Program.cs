using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HowTimesNumberAppears
{
    class Program
    {
        static void NumberAppears(int[] masiv, int myNumber)
        {
            int[] number = new int[100];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = 0;
            }

            for (int i = 0; i < masiv.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {


                    if (masiv[i] == j)
                    {
                        number[j]++;
                    }
                }
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (myNumber == i)
                {
                    Console.WriteLine(number[i]);
                }
                
            }

        }

        static void Main(string[] args)
        {
            int[] masivOne=new int[]{1,2,4,4};
            int chislo = int.Parse(Console.ReadLine());
            NumberAppears(masivOne, chislo);

        }
    }
}
