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
            int max;

         
                if (a>b)
                {
                    max=a;
                    Console.WriteLine(max);}
                    else
                    {
                        max=b;
                        Console.WriteLine(max);
                    }
        }
    }
}
                
            
        
