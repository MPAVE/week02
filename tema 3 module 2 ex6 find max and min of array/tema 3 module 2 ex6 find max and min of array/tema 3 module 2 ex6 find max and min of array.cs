using System;

namespace tema_3_module_2_ex6_find_max_and_min_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 4, 2, 121, 32, 76, 43, 8};
            int min;
            int max;
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            min = arr[0];
            max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("maximul este:" + max);
            Console.WriteLine("min este:" + min);
            Console.ReadLine();
        }
    }
}
