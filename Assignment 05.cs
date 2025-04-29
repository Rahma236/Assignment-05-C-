 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    internal class Program
    {
        #region : (1) Generate a random string of only alphabetical character
        static string GenerateRandomAlphabeticalString(int length)
        {
            string result = default;
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int num = 1; num <= length; num++)
            {
                result += chars[random.Next(chars.Length)];
            }
            return result;
        }
        #endregion
        static void Main(string[] args)
        {
            #region : (1) Generate a random string of only alphabetical character

            Console.Write("Enter Length of String : ");
           bool valid=int.TryParse(Console.ReadLine(), out int length);
            while (!valid ||length<1)
            {
                Console.Write("Enter Positive Number Greater Than zero : ");
                 valid = int.TryParse(Console.ReadLine(), out  length);
            }
            Console.WriteLine($"String is : {GenerateRandomAlphabeticalString(length)}");
            Console.WriteLine("------------------------------------------");

            #endregion

            #region : (2) Runtime Resulting in an Exception and Handle it without Closing the Program
            try
            {
                Console.Write("Enter a number to divide 100 by : ");
                int num = int.Parse(Console.ReadLine());
                double result2 = 100 / num;
                Console.WriteLine($"Result = {result2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            Console.WriteLine("------------------------------------------");
            #endregion

            #region : (3) Calculator App that allows users to perform arithmetic

            double num1 = default;
            double num2=default;
            char operation = default;
            double result3 = default;
            Console.Write("Enter Number 1 :");
            while (!double.TryParse(Console.ReadLine(),out num1))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            Console.Write("Enter Number 2 :");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            Console.Write("Enter symbol : ");
            operation = char.Parse(Console.ReadLine()); 
            switch(operation)
            {
                case'+':
                          result3=num1 + num2;
                    Console.WriteLine($"Number 1 + Number 2 = {result3}");
                    break;

                case '-':
                    result3 = num1 - num2; 
                    Console.WriteLine($"Number 1 - Number 2 = {result3}");
                    break;

                case '*':
                    result3 = num1 * num2;
                    Console.WriteLine($"Number 1 * Number 2 = {result3}");
                    break;

                case '/':
                    if(num2==0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result3 = num1 / num2;
                        Console.WriteLine($"Number 1 / Number 2 = {result3}");
                    }
                    break;

                    default:

                    Console.WriteLine("Error: Unknown operation. Please use +, -, *, or /.");
                    break;
            }
            Console.WriteLine("------------------------------------------");

            #endregion

            #region : (4) where boxing and unboxing happen?
            /*Boxing:
             * ArrayList arr = new ArrayList { 12, "Zyad", 66.3 };
                  objectاليint
                  ( casting لان مافيشunboxingمافيش )
            */
            #endregion

            #region : (5)

            /* 
             * this is called pseudo-random.
             * Random random = new Random();
               rand.Next()	  ----- Returns a random positive integer.
              rand.Next(min, max)	 ------- Returns a random number from min to max - 1.
               rand.NextDouble() --------   Returns a random decimal between 0.0 and 1.0.
             */
            #endregion

            Console.ReadKey();  

        }
    }
}
