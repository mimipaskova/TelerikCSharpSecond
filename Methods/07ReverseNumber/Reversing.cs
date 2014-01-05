using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ReverseNumber
{
    class Reversing
    {
        public void Reverse(int number)
        {
            int reversed=number%10;
            number = number / 10;
            while (number != 0)
            {
                reversed=reversed*10 + number % 10;
                number= number / 10;
            }
            Console.WriteLine(reversed);

        }
    }
}
