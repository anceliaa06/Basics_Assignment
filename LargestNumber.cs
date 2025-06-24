using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class LargestNumber
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Largest Number is: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Largest Number is: " + num2);
            }
            else
            {
                Console.WriteLine("Largest Number is: " + num3);
            }
        }
       
}
}
