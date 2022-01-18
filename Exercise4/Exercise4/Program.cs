using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 932;
            int sum;

            Console.Write("Enter an intger between 0 and 1000:");
            number = int.Parse(Console.ReadLine());

            sum = (sum * number % 100);
            number = number / 10;
            Console.WriteLine("The sum of the digits is : {}");
            sum = int.Parse(Console.ReadLine());
        }
    }
}
