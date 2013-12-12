using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MaxEqualSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = new int[10];
            int br=1;
            int max = 1;
            

            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = int.Parse(Console.ReadLine());
            }

            int value = masiv[0];
            int prom = masiv[0];
            for (int i = 0; i < masiv.Length-1; i++)
            {
                if (masiv[i] == masiv[i + 1])
                {
                    value = masiv[i];
                    br++;
                }
                else
                {
                    if (max < br)
                    {
                        max = br;
                        br = 1;
                        prom = value;

                    }
                }
                
            }

            Console.WriteLine(prom+ " "+ max);

        }
    }
}
