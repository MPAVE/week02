﻿using System;

namespace tema3_module2_ex7_find_common_element_2_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5]{ 1, 2, 3, 4, 5};
            int[] arr2 = new int[5]{ 3, 4, 5, 6, 7};
            for(int i=0; i<arr1.Length; i++)
            {
                for(int j=0; j<arr2.Length; j++)
                {
                    if(arr1[i]==arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
