using System;

namespace Inlämning1_revisited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first operator");
            string operand1 = Console.ReadLine();
            Console.WriteLine("Enter second operator");
            string operand2 = Console.ReadLine();

            Console.WriteLine("Enter first term");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second term");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third term");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.WriteLine("====================");
            Console.WriteLine($"{num1} {operand1} {num2} {operand2} {num3}");
            Console.WriteLine("====================");

        }
            static int Add(int num1, int num2)
            { 
            int sum = num1 + num2;
            return sum;
            }
        static int Subtract(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }
        static int Multiply(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }
        static int Devision(int num1, int num2)
        {
            int sum = num1 / num2;
            return sum;
        }

    }
}
