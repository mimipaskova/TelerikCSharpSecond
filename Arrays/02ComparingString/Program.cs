using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ComparingString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masivOne = new int[10];
            int[] masivTwo = new int[10];
            

            for (int i = 0; i < masivOne.Length; i++)
            {
                masivOne[i] =int.Parse( Console.ReadLine());
                Console.Write("Stoinost na 2 masiv ");
                masivTwo[i] = int.Parse(Console.ReadLine());               
            }

            for (int i = 0; i < masivOne.Length; i++)
            {
                 if (masivOne[i] == masivTwo[i])
                {
                    Console.WriteLine("Raven e na poziciq {0}", i);
                }
            }
        }
    }
}
