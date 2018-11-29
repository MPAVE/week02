using System;

namespace Curs2
{
    public class WhileExample
    {
        public static void Main()
        { //afisare numere desc
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\n");
            while (number>0)
            {
                Console.WriteLine(number+ "\t");
                number --;
            }
        }
    }
}