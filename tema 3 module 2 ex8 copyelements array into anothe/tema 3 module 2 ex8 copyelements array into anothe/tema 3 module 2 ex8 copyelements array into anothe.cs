using System;

namespace tema_3_module_2_ex8_copyelements_array_into_anothe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6]{ 1, 56, 3, 7, 11, 39 };
            int[] arr2 = new int[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            Console.WriteLine();
            foreach(int i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
           
        }
    }
}
