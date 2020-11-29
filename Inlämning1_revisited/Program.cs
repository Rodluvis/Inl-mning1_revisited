using System;
using System.Collections.Generic;

namespace Inlämning1_revisited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inlämningsuppgift 1";
            List<int> resultList = new List<int>();
            bool running = true;
            while (running)
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

                Console.WriteLine("====================");
                Console.WriteLine($"{num1} {operand1} {num2} {operand2} {num3}");
                Console.WriteLine("====================");
                int result = 0;

                if (operand2 == "*" || operand2 == "/")
                {
                    switch (operand2)
                    {
                        case "*":
                            num2 = Multiply(num2, num3);
                            break;
                        case "/":
                            num2 = Devide(num2, num3);
                            break;
                    }
                    switch (operand1)
                    {
                        case "+":
                            result = Add(num1, num2);
                            Console.WriteLine($"The result of your input is: {result}");
                            break;
                        case "-":
                            result = Subtract(num1, num2);
                            Console.WriteLine($"The result of your input is: {result}");
                            break;
                        case "*":
                            result = Multiply(num1, num2);
                            Console.WriteLine($"The result of your input is: {result}");
                            break;

                        case "/":
                            result = Devide(num1, num2);
                            Console.WriteLine($"The result of your input is: {result}");
                            break;
                    }
                }
                else
                {
                    switch (operand1)
                    {
                        case "+":
                            num1 += num2;
                            break;
                        case "-":
                            num1 -= num2;
                            break;
                        case "*":
                            num1 *= num2;
                            break;

                        case "/":
                            num1 /= num2;
                            break;
                    }


                    switch (operand2)
                    {
                        case "+":
                            result = Add(num1, num3);
                            Console.WriteLine($"The result of your input is: {result}");
                            break;
                        case "-":
                            result = Subtract(num1, num3);
                            Console.WriteLine($"The result of your input is: {result}");
                            break;
                    }
                    resultList.Add(result);


                }
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
                static int Devide(int num1, int num2)
                {
                    int sum = num1 / num2;
                    return sum;
                }

            }
        }
    }
