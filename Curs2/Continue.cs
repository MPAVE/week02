using System;

namespace Curs2
{
    public class Continue
    {
        public static void Main()
        {
            //afisare doar nr impare
         for (int i =100; i>0;i--)
         {
             if(i%2==0)
             {
                 continue;
         
             }
             Console.WriteLine(i);
         }

        
        }
    }
}