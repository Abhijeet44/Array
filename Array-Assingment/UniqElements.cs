using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class UniqElements
    {
        static bool isAlreadyPr(int[] a, int curent)
        {
            for (int i = 0; i < curent; i++)
            {
                if (a[i] == a[curent])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 2, 5, 5, 8, 2, 4, 8 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Uniq Elements are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (isAlreadyPr(arr, i) == false)
                {
                    int c = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            c++;
                        }
                    }
                    if(c==1)
                        Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
