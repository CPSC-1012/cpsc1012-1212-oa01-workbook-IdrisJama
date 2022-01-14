using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Idris Jama";

            //int age = 17;

            //Double annualincome = 150_000;

            //Console.WriteLine($"my name is {name}, my age is {age} and I hope to earn {annualincome:c} per year.");

            string name;
            int age;
            double annualPay;

            Console.Write("Enter your name: ");
            name = Console.ReadLine;

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your annual pay: ");
            annualPay = double.Parse(Console.ReadLine());

        }

    }
}
