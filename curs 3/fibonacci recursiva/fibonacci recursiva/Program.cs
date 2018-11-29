using System;

namespace fibonacci_recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many element you want to print");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                int F = fibonacci(i);
                Console.Write(F);
            }
            Console.ReadLine();
        }
        public static int fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + (n - 2);
            }

        }
        }
}
