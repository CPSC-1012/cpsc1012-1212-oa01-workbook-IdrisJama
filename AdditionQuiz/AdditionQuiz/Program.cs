using System;

namespace AdditionQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // define constants for the Minimum  number and Maximum number to genarate
            const int MinNumber = 1;
            const int MaxNumber = 9;
            // Create a Random object that is used to genarate random numbers
            Random rand = new Random();
            // Genarate two random numbers between MinNumber and MaxNumber
            int number1 = rand.Next(MinNumber, MaxNumber + 1);
            int number2 = rand.Next(MinNumber, MaxNumber + 1);
            // Compute the correct answer
            int correctanswer = number1 + number2;
            // Prompt and read in the user answer
            Console.Write($"What is {number1} + {number2} = ? ");
            int userAnswer = int.Parse(Console.ReadLine());
            // Display true if the answer is correct, otherwise, display false
            Console.WriteLine($"{number1} + {number2} = {userAnswer} is {userAnswer == correctanswer} ");
        }
    }
}
