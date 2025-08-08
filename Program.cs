using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get first float number from the user
            Console.Write("Enter the first number: ");
            string firstInput = Console.ReadLine();

            // Validate first number
            if (!float.TryParse(firstInput, out float firstNumber))
            {
                Console.WriteLine("Error: Please enter a valid number.");
                return;
            }
            // Get second float number from the user
            Console.Write("Enter the second number: ");
            string secondInput = Console.ReadLine();

            // Validate second number
            if (!float.TryParse(secondInput, out float secondNumber))
            {
                Console.WriteLine("Error: Please enter a valid number.");
                return;
            }
            // Get operator from the user
            Console.Write("Enter an operator (+, -, *, /): ");
            string operatorInput = Console.ReadLine();

            // Perform the operation based on the operator
            switch (operatorInput)
            {
                case "+":
                    Console.WriteLine($"Result: {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {firstNumber - secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {firstNumber * secondNumber}");
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {firstNumber / secondNumber}");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator. Please use +, -, *, or /.");
                    break;
            }
        }
    }
}






