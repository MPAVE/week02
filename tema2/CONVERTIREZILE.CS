using System;
namespace ConsoleApplication
{
    public class CONVERTIREZILE 
    {
        public static void Main()
        {
        
            string temp1 = Console.ReadLine();
            int a = Convert.ToInt32(temp1);
            int y; int m; int w;
            y=a/365;
            Console.WriteLine("numarul de ani este:"+y);
        a=a%365;
        if (a>30)
        {
            Console.WriteLine("nr de luni este:"+a);}
            else
            {
                Console.WriteLine("nu avem luni");
            }
        
        m=a/30;
        Console.WriteLine("Numarul de luni este:"+m);
        a=a%30;
        if (a>7)
        {
            Console.WriteLine("numarul de sapt este:"+a);}
        
        w=a/7;
        Console.WriteLine("numarul de sapt este:"+w);
        a=a%7;
        Console.WriteLine("numarul de zile este"+a);
        }
    }
}
