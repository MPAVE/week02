using System;

namespace exercitii_curs_3_prob_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberToGuess = new Random().Next(1, 10);
            var ok = false;
            while (ok==false)// while (!ok)// putem scoate variabial ok si punem in while(true) si scoatem ok=true si scriem break; si sterg else si scriu doar console
            {
                Console.WriteLine("introduceti un numari:");
                var x = Convert.ToInt32(Console.ReadLine());

                if (x == numberToGuess)
                {
                    Console.WriteLine("ati ghicit numarul");
                    ok = true;
                }
                else
                {//sau console.writeline(x<numbertoguess? "numarul este prea mic" : "numarul este prea mare"");
                    if(x<numberToGuess)
                    {
                        Console.WriteLine("numarul este prea mic");
                    }
                    else
                    {
                        Console.WriteLine("numarul este prea mare");
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
