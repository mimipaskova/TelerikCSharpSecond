﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[,] matrix= new int[n, n];
           // int[,]matrixTwo=new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i+4*j+1;
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]+ " " );
                }
                Console.WriteLine();
            }



        }
    }
}
