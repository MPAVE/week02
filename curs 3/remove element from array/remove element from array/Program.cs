using System;

namespace remove_element_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 17, 2, 7,2,8 };
            int value = 2;
            //aflu pozitia
            var index = FindIndex(arr, value);
            var occuriences = FindOccurances(arr, value);


            int[] newArray = new int[arr.Length-occuriences];
            int counter = 0;// pot sa pun si fara 0 pentru ca e default

            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == value)// scoatem indexul
                {
                    continue;
                }
                
                newArray[counter] = arr[i];
                counter++;
            }
            for(int i=0;i<newArray.Length;i++)
            {
                Console.WriteLine(newArray[i] + " ");
            }
            Console.ReadLine();
        }
        public static int FindIndex(int[]array,int value)
        {
            for(int i=0;i<array.Length;i++)

            {
                if(array[i]==value)
                {
                    return 1;
                }
            }
            return -1;
        }

        //facem o functie ca sa intoarca de cate ori apare un element intrun sir
        public static int FindOccurances(int[]array, int value)
        {
            int counter = 0;
            foreach (var element in array)
            {
                if(element==0)
                {
                    counter++;

                }
            }
            return counter;
        }
    }
}
