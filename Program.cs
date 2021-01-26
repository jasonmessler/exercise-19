using System;

namespace exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int i;
            string yOrN;

            do
            {
                var sum = 0;
                Console.Write("Enter a number: ");
                string num1Entry = Console.ReadLine();
                num1 = int.Parse(num1Entry);

                Console.Write("Enter another number: ");
                string num2Entry = Console.ReadLine();
                num2 = int.Parse(num2Entry);

                for (i = num1; i <= num2; i++) 
                {
                    sum = sum + i;
                }
                Console.WriteLine($"The sum of all the numbers between {num1} and {num2} is: {sum}");
                Console.WriteLine();
                Console.Write("Would you like to continue (y/n)? ");
                yOrN = Console.ReadLine();
            } while (yOrN == "y");
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Goodbye!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
