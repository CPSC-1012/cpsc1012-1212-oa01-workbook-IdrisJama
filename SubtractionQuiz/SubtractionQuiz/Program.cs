using System;

namespace SubtractionQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Genarate two random single digit integers
            Random keygen = new Random();
            int number1 = keygen.Next(1, 100);
            int number2 = keygen.Next(1, 100);
        }
    }
}
