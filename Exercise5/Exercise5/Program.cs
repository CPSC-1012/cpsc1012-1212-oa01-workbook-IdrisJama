using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter investment amount: ");
            double investmentamount = double.Parse(Console.ReadLine());

            Console.Write("Enter annual interest rate in percantage: ");
            double annualinterestrate = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            double numberofyears = double.Parse(Console.ReadLine());

            double futureinvestmentvalue = investmentamount * (1 + annualinterestrate) 
        }
    }
}
