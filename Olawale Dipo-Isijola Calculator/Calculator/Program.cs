using System;

namespace SimpleCalculator
{
    public class Program
    {
        class Calculator
        {
            static void Main()
            {
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an operator (+, -, *, /):");
                string operatorInput = Console.ReadLine();

                double result = 0;

                switch (operatorInput)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operator.");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }
        }
    }

}