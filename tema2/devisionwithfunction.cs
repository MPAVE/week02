using System;
namespace ConsoleApplication
{
    public class Devision
    {
        public static void Main()
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            string temp1 = Console.ReadLine();
            String temp2 = Console.ReadLine();
            int a = Convert.ToInt32(temp1);
            int b = Convert.ToInt32(temp2);


            //int devision = a / b;
            int DEV = dev(a, b);
            //int multiplication = a * b;
            int MUL = mult(a, b);
            Console.WriteLine("the result of division is:" + DEV);
            Console.WriteLine("the result of multiplication is:" + MUL);
            Console.ReadKey();

        }
        public static int dev(int a, int b)
        {
            return a / b;
        }
        public static int mult (int a, int b)
        {
            return a * b;
        }
    }
}
