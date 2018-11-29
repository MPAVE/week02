using System;
namespace ConsoleApplication
{
    public class nrzile
    {
        public static void Main()
        {
            //int a = Convert.ToInt32(Console.ReadLine());
           
            string temp1 = Console.ReadLine();
           
            int a = Convert.ToInt32(temp1);
            int y; int m; int w;
            y=a/365;
            a=a%365;
            m=a/30;
            a=a%30;
            w=a/7;
            a=a%7;
            Console.WriteLine(y,m,w,a);
        }
    }
}