using System;

namespace curs_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 11;
            numbers[2] = 13;
            numbers[3] = 14;
            numbers[4] = 15;
            /* for(int i=numbers.Length-1;i>=0;i--)
             {
                 if (i == 0)
                 {
                     Console.WriteLine(numbers[i]);
                 }
                 else
                 //Console.WriteLine(numbers[i]);
                 {
                     Console.Write(numbers[i] + ",");
                 }

             }
             Console.ReadLine();*/

            //int[] aux = new int[numbers.Length];
            //int j = 0;
            int x;
            for(int i=0; i< numbers.Length/2;i++)
            {
                Swap(numbers, i, numbers.Length - i - 1);
                
            }
            WriteNumbers(numbers);
            Console.ReadLine();
        }
        public static void Swap(int[]arr, int i, int j)
        {
            var x = arr[i];//var il putem folosi doar pt ca deduce tipul integer
            arr[i] = arr[j];
            arr[j] = x;
        }
            
            //zitiile pe care le schimb i si j
        public static void WriteNumbers(int[] aux)
        {
            for (int i = 0; i <= aux.Length- 1; i++)
            {
                if (i == aux.Length-1)
                {
                    Console.Write(aux[i]);
                }
                else
                {
                    Console.Write(aux[i] + ",");
                }
            }
        }
    }
}
