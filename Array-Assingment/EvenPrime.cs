using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class EvenPrime
    {
        static bool isPrime(int n)
        {
            for(int i=2; i<=n; i++)
            {
                if (n % 2 == 0)
                    return false; 
            }
            return true;
        }

        static bool isEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 7, 3, 13, 2 };

                     // { 5, 2, 7, 3, 13, 9 };


            int[] p = new int[arr.Length];
            int[] e = new int[arr.Length];
            int[] r = new int[arr.Length];

            int[] n = new int[arr.Length];
 
            for(int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]) == true)
                    p[i] = arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (isEven(arr[i]) == true)
                    e[i] = arr[i];
            }

            for (int i = 0; i < p.Length; i++)
            {
                Console.Write(p[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < e.Length; i++)
            {
                Console.Write(e[i] + " ");
            }
        }
    }
}
