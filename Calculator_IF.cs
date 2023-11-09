using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            Console.Write("Enter the first number: ");

            string num1 = Console.ReadLine();

            if (double.TryParse(num1 ,out double number1))
            {
            }
            else
            {
                Console.WriteLine("Wrong input !");
                return;
            }

            Console.Write("Enter the second number: ");
            string num2 = Console.ReadLine();
            if (double.TryParse(num2, out double number2))
            {
            }
            else
            {
                Console.WriteLine("Wrong input !");
                return;
            }

            Console.WriteLine("Choose the operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");

            int choice = Console.Read();

            double result = 0;

           
            if (choice == 1)
            {
                result = number1 + number2;
            }
            else if (choice == 2)
            {
                result = number1 - number2;
            }
            else if (choice == 3)
            {
                
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
            }
            else if(choice == 4)
            {
                result = number1 * number2;
            }

            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
