/*   Purpose:  Compute the total of a sale item using the price and tax
 * 
 *   Input:    Price in dollars and cents
 * 
 *   Outputs:  Sales total 
 * 
 *  Algorithm: Step 1) Prompt and read in the sale price 
 *             Step 2) Calculate the sale total using the formula:
 *                     salesTax = sales Price * 0.05
                       saleTotal = salePrice + salesTax
 *                              Or
 *                     saleTotal = salePrice * (1 + gstRate)
 *                     
 *             Step 3) Display the computed sale total
 *             
 *  Last modifed: 2022-01-12
 * */
using System;

namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs and outputs
            double saleprice;
            const double SaleTaxRate = 0.05;
            double saletax;
            double saleTotal;
            string userinput;


            // step 1) Prompt and read in the sale price
            Console.Write("Enter the sale price: ");
            userinput = Console.ReadLine();
            // Convert userInput from a string type to double type
            saleprice = double.Parse(userinput);
            //saleprice = double.Parse(Console.ReadLine());


            // Step 2) Calculate the sale total
            saletax = saleprice * SaleTaxRate;
            saleTotal = saleprice + saletax;


            // Step 3) Display the computed sale total
            /*   1234567890  12345678
             *   Price:      $29.75
             *   Tax:        $1.76
             *   Total:      $31.51
             * */
            Console.WriteLine($"{"Price:",-10} {saleprice, 8:c}");
            Console.WriteLine($"{"Tax:",-10} {saleTax,8:c}");
            Console.WriteLine($"{"Total:",-10} {saleTotal,8:c}");

        }
    }
}
