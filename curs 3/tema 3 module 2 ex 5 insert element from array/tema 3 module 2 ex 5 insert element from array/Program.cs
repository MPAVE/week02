using System;

namespace tema_3_module_2_ex_5_insert_element_from_array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 17, 2, 7, 2, 8 };
            int value = 2;
            //aflu pozitia
            var index = 3;
            int[] newArray = new int[arr.Length + 1];

            int counter = 0;
            for (int i = 0; i <= arr.Length; i++)
            {
                if(i==index)
                {
                    newArray[i] = value;
                    counter++;
                }
                else
                {
                    newArray[i] = arr[i - counter];
                }

            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + " ");
            }
        }
      /*  public static void Removeelementfromarray()
        {
            int[] arr = new int[] { 1, 17, 2, 7, 2, 8 };
            int value = 2;
            //aflu pozitia
            var index = FindIndex(arr, value);
            var occuriences = FindOccurances(arr, value);


            int[] newArray = new int[arr.Length - occuriences];
            int counter = 0;// pot sa pun si fara 0 pentru ca e default

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)// scoatem indexul
                {
                    continue;
                }

                newArray[counter] = arr[i];
                counter++;
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + " ");
            }
            Console.ReadLine();
        
    }
    }
}
