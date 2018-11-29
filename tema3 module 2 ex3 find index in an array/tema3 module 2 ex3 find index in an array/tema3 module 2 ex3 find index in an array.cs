using System;

namespace tema3_module_2_ex3_find_index_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            arr[0] = 1;
            arr[1] = 33;
            arr[2] = 54;
            arr[3] = 5;
            arr[4] = 13;
            arr[5] = 21;
            // int index = Array.IndexOf(arr, 13);
            // Console.WriteLine(index);
            Console.WriteLine(Array.IndexOf(arr, 13));
            
            Console.ReadLine();
        }
    }
}
