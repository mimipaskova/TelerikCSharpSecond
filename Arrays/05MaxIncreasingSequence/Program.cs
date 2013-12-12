using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MaxIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv=new int[7];

            for (int i = 0; i < masiv.Length; i++)
			{                
                masiv[i]=int.Parse(Console.ReadLine());			 
			}

            int value=masiv[0];
            int br=1;
            int max=1;

            for (int i = 1; i < masiv.Length; i++)
			{
                if(masiv[i]>masiv[i-1])
                {
                    br++;                    
                }
                else
                {
                    if(max<br)
                    {
                        max=br;
                        br=1;

                    }
                }
			}
            Console.WriteLine();
            Console.WriteLine(max);
        }
    }
}
