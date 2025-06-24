using System;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator ");
            Console.WriteLine("1. ADD ");
            Console.WriteLine("2. SUBTRACT ");
            Console.WriteLine("3. MULTIPLY ");
            Console.WriteLine("4. DIVIDE ");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = firstNumber + secondNumber;
                        Console.WriteLine("the addition is :"+result);
                        break;
                    }
                case 2:
                    {
                        result = firstNumber - secondNumber;
                        Console.WriteLine("the subtraction is :"+result);
                        break;
                    }
                case 3:
                    {
                        result = firstNumber * secondNumber;
                        Console.WriteLine("the multiplication is :"+result);
                        break;
                    }
                case 4:
                    {
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                            Console.WriteLine("the multiplication is :"+result);
                        }
                        break;
                    }
            }
        }
    }
}
