using System;

namespace tema_3_module_2_frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrie dimensiunea array ului:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] freq = new int[n];

            int i; int j;
            int count;
            
            Console.WriteLine("scrie elementele din array:");
            for (i =0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                freq[i] = -1;
            }
            for (i=0;i<n;i++)
            {
                count = 1;
                for(j=i+1;j<n;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        count++;
                        freq[j] = 0;
                    }
                }
                if(freq[i]!=0)
                {
                    freq[i] = count;
                }
            }
            Console.WriteLine("numerele duplicate sunt:");
            for(i=0;i<n;i++)
            {
                if(freq[i]!=0)
                {
                    Console.WriteLine("numarul" + arr[i] + "apare de" + freq[i] + "ori");
                }
            }
            Console.ReadLine();
        }
    }
}
