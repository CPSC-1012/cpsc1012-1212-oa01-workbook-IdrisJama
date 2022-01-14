/* Purpose : Compute the area of the hexagon
 * 
 * Input: Side of the hexagon 
 * 
 * Output: Area of the heaxagon
 * 
 * Algorthim: step 1) Prompt and read the sides of the heaxagon
 *            step 2) Compute the area of the hexagon using the formula
 *              Area = 3 x side^2/2
 *            step 3) Display the area of the hexagon
 * */

using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1) Prompt and read the sides of the heaxagon
            Console.Write("Enter the length of the side of the hexagon: ");
            double side = double.Parse(Console.ReadLine());
            //step 2) Compute the area of the hexagon using the formula
            double area = (3 * Math.Sqrt(3) / 2) * side * side  ;
            //step 3) Display the area of the hexagon
            Console.WriteLine($"the area of the heaxagon is {area}");
            // F3 means 3 decimal points
        }
    }
}
