using System;

namespace ArithmeticProblems2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Value for the variable a; ");
            double a = int.Parse(Console.ReadLine());

            Console.Write("Enter the Value for the variable b; ");
            double b = int.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine($"The length of the hypotenuse is: {c} ");
        }
    }
}
