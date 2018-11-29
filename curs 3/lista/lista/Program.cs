using System;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        /*// ex1 afisare nr pare intre 15 si 97
             for(int i=15;i<=97;i++)
             {
                 if(i%2==0)// ca sa scap de is if pun in for i=16 si i=i+2 sau 1+=2
                 {
                     Console.WriteLine(i);
                 }
             }*/
        {
            for (int i = 20; i <= 65; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        }
    }
}
