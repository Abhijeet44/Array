using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class DuplicateElem
    {
        
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 2, 7, 8, 8, 3 };


            Console.WriteLine("Duplicates in Array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);

                }
            }
        }
                
    }
}
