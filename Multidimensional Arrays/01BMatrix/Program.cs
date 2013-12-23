using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[,] matrix=new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                    {
                        matrix[i,j]=i + n * j + 1;
                    }
                    else
                    {
                        matrix[i, j] =-i+(j+1)* n;
                    }

                }                
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]+ " ");
                }
                Console.WriteLine();
            }


        }
    }
}
