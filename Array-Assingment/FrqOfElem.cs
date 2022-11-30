using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class FrqOfElem
    {
        static bool isAlreadyPr(int[] a, int curent)
        {
            for(int i = 0; i < curent; i++)
            {
                if(a[i] == a[curent])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 4, 2, 1, 9, 8 };

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if(isAlreadyPr(arr, i) == false)
                {
                    int c = 1;
                    for(int j = i+1; j < arr.Length; j++)
                    {
                        if(arr[i] == arr[j])
                        {
                            c++;
                        }
                    }
                    Console.WriteLine("Frequncy of " + arr[i] + " : " + c);
                }
            }
            

        }
    }
}
