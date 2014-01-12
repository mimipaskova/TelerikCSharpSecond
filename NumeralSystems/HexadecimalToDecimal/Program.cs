using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            double[] resultOne = new double[10];
            double result = 0;
            int ostatuk = 0;

            int i = number.Length-1;
            while (i!=-1)
            {

               // Console.WriteLine(number[i]);
                switch (number[i])
                {
                    case 'A': ostatuk = 10; break;
                    case 'B': ostatuk = 11; break;
                    case 'C': ostatuk = 12; break;
                    case 'D': ostatuk = 13; break;
                    case 'E': ostatuk = 14; break;
                    case 'F': ostatuk = 15; break;
                    default: ostatuk = int.Parse(number[i].ToString());
                        break;
                }
               // Console.WriteLine(ostatuk);
                
                
                result += ostatuk * Math.Pow(16, number.Length- i-1);
                //number = number / 10;
                i--;

            }

            Console.WriteLine(result);
        }
    }
}
