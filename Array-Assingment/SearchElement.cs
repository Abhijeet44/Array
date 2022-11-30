using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class SearchElement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Size of Array : ");
            int s = int.Parse(Console.ReadLine());

            int[] arr = new int[s];

            Console.WriteLine("Enter the Elements of Array : ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entered Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nEnter the Element to Search : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
               if(arr[i] == x)
               {
                   Console.WriteLine(x + " is at index " + i);
               }
            }

        }
    }
}
