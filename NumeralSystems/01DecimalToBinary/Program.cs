using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] length = new int[10];
            Console.WriteLine("Vuvedi chislo");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedi broina sistema kato 4islo");
            int convertSystem = int.Parse(Console.ReadLine());

            int i = 0;

            while (number != 0)
            {
               
                    length[i] = number % convertSystem;
                    number = number / convertSystem;
                    i++;
            }

            for (int j = i-1; j >= 0; j--)
            {
                Console.Write(length[j]);
                
            }

        }
    }
}
