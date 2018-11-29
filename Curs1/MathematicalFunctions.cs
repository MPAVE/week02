using System;
namespace ConsoleApplication
{
    public class MathFunctions
    {

        public static void Main()
        {
        Console.WriteLine("Please add the first number");
          string temp1 =Console.ReadLine(); //CITIRE 2 VARIABILE
           Console.WriteLine("Please add the second number");
          string temp2 =Console.ReadLine();
//TRANSFORMARE
            int number1 =Convert.ToInt32(temp1);
            int number2 =Convert.ToInt32(temp2);

            int sum = Sum(number1,number2);//= number1+number2;
            
            int dif =Dif(number1,number2);

            Console.WriteLine("suma este:"+sum);
            Console.WriteLine("diferenta este:"+dif);
        }

    public static int Sum(int number1, int number2)
    {
        //int sum= number1+number2;
       // return sum;
        return number1+number2;
    }
    public static int Dif(int number1, int number2)
    {
        return number1-number2;

    }
    }



}