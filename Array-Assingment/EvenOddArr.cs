using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class EvenOddArr
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int p = 0;
            int n = 0;
            int[] even = new int[arr.Length];
            int[] odd = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    even[p] = arr[i];
                    p++;
                }
                else
                {
                    odd[n] = arr[i];
                    n++;
                }
            }

            Console.WriteLine("Even : ");
            for(int i = 0; i < p; i++)
            {
                Console.Write(even[i] + " ");
            }
            Console.WriteLine("\nOdd : ");
            for(int i=0; i < n; i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
    }
}
