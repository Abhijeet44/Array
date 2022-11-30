using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class NegativeElementarr
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 10, 20, 30, -40, -50, -60, -70 };

            int n = 0;
            int[] neg = new int[arr.Length];

            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    n++;
                    neg[n] = arr[i]; 
                }
            }
            Console.WriteLine("Total Negative Elements are : " + n);
            for(int i = 0; i <= arr.Length; i++)
            {
                Console.Write(neg[n]);
            }
        }
    }
}
