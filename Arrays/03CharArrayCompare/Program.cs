using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CharArrayCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] masivOne = new char []{'a','b' };
            char[] masivTwo = new char[] { 'a','b' };
            bool flag = true;

            for (int i = 0; i < masivOne.Length; i++)
            {
                if (!(masivOne[i].Equals(masivTwo[i])))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Ednakvi sa");
            }
        }
    }
}
