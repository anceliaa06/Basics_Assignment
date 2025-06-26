namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER THE NUMBER TO CHECK IF PALINDROME:");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder = 0;
            int sum = 0;
            int temp = number;
            while (remainder > 0)
            {
                remainder = temp % 10;
                sum = (sum * 10) + remainder;
                temp = temp / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }
    }
}
