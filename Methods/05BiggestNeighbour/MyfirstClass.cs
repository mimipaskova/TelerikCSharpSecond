using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BiggestNeighbour
{
    public class BiggestNumber
    {
        public bool BiggestNeighbour(int[] masiv, int position)
        {
            bool isBiggest = false;
            if (position <= 0 || position >= masiv.Length-1)
            {
                return false; 
            }
             if (masiv[position] > masiv[position + 1] && masiv[position] > masiv[position - 1])
            {
                isBiggest = true;

            }
            return isBiggest;

        }
    }
}
