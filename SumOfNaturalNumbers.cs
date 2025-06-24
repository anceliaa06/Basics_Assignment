using System;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            for (i =0; i<= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("\n Sum:  " +sum);
        }
    }
}
