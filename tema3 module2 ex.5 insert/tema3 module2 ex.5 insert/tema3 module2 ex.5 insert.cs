using System;

namespace tema3_module2_ex._5_insert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrie dimensiunea array ului:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("scrie elementele din array:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("scrie ce element vrei sa inserezi in :");
            int insert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("scrie pe ce pozitie vrei sa inserezi:");
            int poz = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length+1; i++)
            {
                if (i == poz)
                {
                    
                    //int var = arr[i];
                    arr[i + 1] = arr[i];
                    arr[i] = insert;
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
