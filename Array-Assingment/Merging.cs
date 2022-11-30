using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class Merging
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int[] arr2 = { 80, 90, 70, 20, 40, 50 };

            int[] arr3 = new int[ arr1.Length + arr2.Length ];

            for(int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for(int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length + i] = arr2[i];
            }

            for(int i = 0; i < arr3.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr3.Length; i++)
                {
                    if (arr3[i] == arr3[j])
                        count++;
                }
                if(count == 1)
                    Console.WriteLine(arr3[i] + " ");
            }

        }
    }
}
