using System;

namespace tema3_module_2_ex._4_remove_element_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrie dimensiunea array ului:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("scrie elementele din array:");
            bool isDeleted = false;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("scrie ce element vrei sa stergi din :");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] == s)
                {
                    arr[i] = arr[i + 1];
                    isDeleted = true;
                }
            }
            if(isDeleted ==false)
            {
                Console.WriteLine("Nr nu exista in array");
            }
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
