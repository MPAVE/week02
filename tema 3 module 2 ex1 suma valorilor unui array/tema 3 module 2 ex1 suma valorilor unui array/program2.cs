using System;

namespace tema_3_module_2_ex1_suma_valorilor_unui_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 6, 3, 5, 23, 54 };
            int suma = 0;
          

            for (int i = 0; i <arr.Length; i++)
            {
                suma = suma + arr[i];

            }
            Console.WriteLine("suma valorilor este:" + suma);
            Console.ReadLine();
        }
    }
}
