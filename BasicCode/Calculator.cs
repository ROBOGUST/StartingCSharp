using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    internal class Calculator
    {
        public static void ShowCalculator()
        {
            while (true)
            {
                double num1, num2, result = 0;
                char operation;

                // User input for numbers
                Console.WriteLine("Enter the first number:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                num2 = Convert.ToDouble(Console.ReadLine());

                // User input for the operation
                Console.WriteLine("Enter an operator (+, -, *, /):");
                operation = Convert.ToChar(Console.ReadLine());

                // Perform the calculation based on the operator
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num1 != 0 && num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Error! Division by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                // Display the result if a valid operation was performed
                if (operation == '+' || operation == '-' || operation == '*' || (operation == '/' && num2 != 0))
                    Console.WriteLine("The result is: " + result);
            }
        }
    }
}
