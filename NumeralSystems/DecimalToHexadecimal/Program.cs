using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] length = new string[20];
            Console.WriteLine("Vuvedi chislo");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedi broina sistema kato 4islo");
            int convertSystem = int.Parse(Console.ReadLine());
            int ostatuk = 0;

            int i = 0;

            while (number != 0)
            {

                ostatuk= number % convertSystem;                
                length[i] =ostatuk.ToString();
                switch (length[i])
                {
                    case "10": length[i] = "A";
                        break;
                    case "11": length[i] = "B";
                        break;
                    case "12": length[i] = "C";
                        break;
                    case "13": length[i] = "D";
                        break;
                    case "14": length[i] = "E";
                        break;
                    case "15": length[i] = "F";
                        break;
                    default:
                        break;
                }
                number = number / convertSystem;
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(length[j]);

            }
            Console.WriteLine();
        }
    }
}
