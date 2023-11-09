using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            Console.Write("Enter the first number: ");

            string num1 = Console.ReadLine();

            if (double.TryParse(num1, out double number1))
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

            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;
            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                   
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                        return;
                    }
                    break;

                    case 4:
                    result = number1 * number2;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }
            Console.WriteLine("Result: " + result);

        }
    }
}
