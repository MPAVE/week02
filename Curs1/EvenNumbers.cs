using System;
namespace ConsoleApplication
{
    public class EvenNumbers
    {

        public static void Main()
        {
          
           //string temp =Console.ReadLine();
           // int i = Convert.ToInt32(temp);
           //sau
           int number=Convert.ToInt32(Console.ReadLine());
           
            if(Modulo(number,2)==0)
            {
                Console.WriteLine("acesta este nr par");
            }
            else
            {
                Console.WriteLine("acesta este nr impar");
            }

    
        }
        public static int Modulo(int number1, int number2)

        {
            return number1%number2;
        }
    }
}