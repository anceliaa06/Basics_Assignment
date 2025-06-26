namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER THE NUMBER TO CHECK IF PALINDROME: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder; //for last digit
            int sum = 0; //reversed
            int temp = number; //to hold the original number

            while (temp > 0)
            {
                remainder = temp % 10; //extract last digit
                sum = (sum * 10) + remainder; //reverses number
                temp = temp / 10;  //removes last digit from temp
            }

            if (number == sum)
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
