using System;

namespace cSharpSwapNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the number 1...: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the number 2...: ");
            num2 = int.Parse(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("number 1 is " + num1 + " and number is = " + num2);
        }
    }
}
