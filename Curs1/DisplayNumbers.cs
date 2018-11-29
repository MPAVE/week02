using System;
namespace ConsoleApplication
{
    public class DisplayNumbers
    {

        public static void Main()
        { //afisare nr de la 1 la 10 cresc
            for (int i=1;i<11;i++) //i=i +2) pentru a merge din 2 in 2 
            {
                Console.WriteLine(i);
            }
             for (int i=10; i>0; i--) //pentru a afisa descrescator nr
             {
                 Console.WriteLine(i);
             } 
        }
    }
}