using System;

namespace ArithmeticProblems1
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.Write("Enter intger 1: ");
            double number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter intger 2: ");
            double number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter intger 3: ");
            double number3 = int.Parse(Console.ReadLine());

            double sum = (number1 + number2 + number3) / 3;

            Console.WriteLine($"The mean is {sum }: ") F3;
        }
    }
}