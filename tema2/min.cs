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
            int min;

         
                if (a<b)
                {
                    min=a;
                    Console.WriteLine(min);}
                    else
                    {
                        min=b;
                        Console.WriteLine(min);
                    }
        }
    }
}
                
            
        
