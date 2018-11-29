using System;
namespace ConsoleApplication
{
    public class imposibile 
    {
        public static void Main()
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            string temp1 = Console.ReadLine();
            String temp2 = Console.ReadLine();
            int a = Convert.ToInt32(temp1);
            int b = Convert.ToInt32(temp2);

            
            

           
    decimal devision;
            if(b==0)
            {
                devision= 0;
                Console.WriteLine("it's not possibile");

            }
            else
            { devision = Convert.ToDecimal (a)/Convert.ToDecimal(b);
                Console.WriteLine(devision);
            }
            
        }
    }
}
