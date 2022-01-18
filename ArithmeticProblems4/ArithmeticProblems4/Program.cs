/* Purpose: Sum the digits of a number
 * 
 * Inputs: A three digit number
 * 
 * Outputs: The sum of the digits of the number
 * 
 * Algorithm: Step 1) Prompt and read the number
 *            Step 2) Extract digit from the right of the number
 *                Digit1 = number % 10
 *            Step 3) Remove digit1 from the number
 *                number = number / 10
 *            Step 4) Extract digit from the right of the number
 *                Digit2 = number % 10   
 *            Step 5) Remove digit1 from the number
 *                number = number / 10
 *            Step 6) Extract digit from the right of the number
 *                Digit3 = number % 10  
 *            Step 7) Remove digit1 from the number
 *                number = number / 10
 * 
 * */
using System;

namespace ArithmeticProblems4
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalnumber,
                number,
                digit1,
                digit2,
                digit3,
                sum;

            Console.Write("Enter the number to sum digits for: ");
            originalnumber = int.Parse(Console.ReadLine());

            number = originalnumber;

            digit1 = number % 10;
            number = number / 10;
            digit2 = number % 10;
            number = number / 10;
            digit3 = number % 10;
            number = number / 10;

            sum = digit1 + digit2 + digit3;

            Console.WriteLine($"The sum of the number {originalnumber} is {sum}");

        }
    }
}
