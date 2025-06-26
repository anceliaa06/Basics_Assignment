namespace MultiplicationChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER AN INTEGER:!");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n MULTIPLICATION TABLE OF {n}");
            for (int i = 1; i <= 10; i++)
            {
                int result = n * i;
                Console.WriteLine($"{n} * {i} = {result}");
            }
        }
    }
}
