using System;

namespace Curs2
{
    public class Break
    {
        public static void Main()
        {
            //afisare doar nr impare
         int i =100;
         while(i>0)
             {
                 if(i%7==0)
                 {
                 break;
                 }
             
             Console.WriteLine(i);
             i--;
         }


        
        }
    }
}