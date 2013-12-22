using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08SequenceMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{4,-8,8};

          //  int sum = 0;
         //   int s = int.MinValue;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i; j < array.Length-1; j++)
            //    {

                    int sum = array[0], max_ending_here = array[0];

                   
                    for ( int i = 1; i < array.Length; i++)
                    {
                        if (max_ending_here < 0)
                        {
                            max_ending_here = array[i];
                        }
                        else
                        {
                            max_ending_here += array[i];
                        }

                       if (max_ending_here >= sum)
                        {
                            sum = max_ending_here;

                        }
                    }
                    Console.WriteLine(sum);
                    Console.ReadLine();

                    //if (s <= array[j])
                    //{
                    //    sum += array[j];
                    //    s = array[j];
                    //}
                    //else if (array[j]<=0 && array[j + 1] > array[j])
                    //{
                    //    sum += array[j]+array[j+1];
                    //    s = array[j+1];
                    //    j++;
                    //}
                    //else
                    //{
                    //    sum = 0;
                    //    break;
                    //}
             //   }
           // }

          //  Console.WriteLine(sum);
           
        }
    }
}
