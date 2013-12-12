using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01NumbersMultiplie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = new int[20];

            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = i * 5;                
            }
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.WriteLine(masiv[i]);
            }

        }
    }
}
