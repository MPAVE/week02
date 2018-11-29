using System;
using System.Linq;

namespace exercitii_curs_3_ex_5
{
    class Program
    {
        static void Main(string[] args)
        {//read reverse word
            Console.WriteLine("introduceti sirul de caractere");
            var s = Console.ReadLine();
            var arr = s.ToCharArray();
            for ( var i =arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]);
            }

        //Console.Write(s.Reverse());
            Console.ReadKey();
        }

    }
}
