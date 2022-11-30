using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class OverLoadAvg
    {
        public static int Avg(int[] arr)
        {
            int sum = 0;
            for(int i=0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum / arr.Length;
        }

        public static double Avg(double[] arrd)
        {
            double sum = 0;
            for(int i=0; i < arrd.Length; i++)
            {
                sum = sum + arrd[i];
            }
            return sum / arrd.Length;
        } 
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] arrd = { 1.2, 1.3, 1.4, 1.5 };

            int i = OverLoadAvg.Avg(arr);
            double d = OverLoadAvg.Avg(arrd);

            Console.WriteLine("Avg of int[] : " + i);
            Console.WriteLine("Avg of double[] :");

        }
    }
}
