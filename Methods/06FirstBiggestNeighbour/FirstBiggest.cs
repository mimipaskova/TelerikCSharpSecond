using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05BiggestNeighbour;

namespace _06FirstBiggestNeighbour
{
    class FirstBiggest
    {
        BiggestNumber myNumber = new BiggestNumber();

        public int FirstBiggestNum(int[] masiv)
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                if (myNumber.BiggestNeighbour(masiv,i))
                {
                    return i+1;
                }                
            }
            return -1;
        }
        
    }
}
