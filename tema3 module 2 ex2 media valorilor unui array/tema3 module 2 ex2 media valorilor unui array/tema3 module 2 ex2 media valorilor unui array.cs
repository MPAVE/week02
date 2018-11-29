using System;

namespace tema3_module_2_ex2_media_valorilor_unui_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 5, 7, 8, 8 };
            int suma = 0;
            decimal medie=0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma = suma + arr[i];
            }
          medie = suma / arr.Length;
            Console.WriteLine("suma este:" + suma);
            Console.WriteLine("media este:" + medie);
            Console.ReadLine();

        }
    }
}
