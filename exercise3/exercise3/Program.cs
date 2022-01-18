/* Purpose: compute the area and valume of the cylinder
 * 
 * Inputs: Radius and Length
 * 
 * outputs: Area and Volume of the cylinder
 * 
 * Algorthim: Step 1) Prompt and read the length and radius
 *            Step 2) Compute the area and volume using the forumla:
 *                    Area = radius * radius * 3.14
 *                    Volume = area * length
 *            Step 3) Display the Area and Volume
 * */

using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1) Prompt and read the length and radius
            //Console.Write("Enter the length of the Cylinder");
            Console.Write("Enter the Radius of the Cylinder");

           // double Length = double.Parse(Console.ReadLine());
            double radius = double.Parse(Console.ReadLine());

            //Step 2) Compute the area and volume using the forumla:
            double area = (radius * radius * Math.PI);
            //double volume = (area * Length);

            //Step 3) Display the Area and Volume
            Console.WriteLine($"The Area of the cylinder is {area} : ");
            
        }
    }
}
