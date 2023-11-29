using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        while (true)
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double result = 0;

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
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please enter a valid operator.");
                    break;
            }

            Console.WriteLine($"Result: {result}");

            Console.Write("Do you want to perform another calculation? (Y/N): ");
            char continueCalculation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.ToUpper(continueCalculation) != 'Y')
                break;
        }
    }
}
