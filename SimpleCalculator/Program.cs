using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();
            Console.WriteLine("Please enter your first number.");
            double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            Console.WriteLine("Please enter your second number.");
            double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            Console.WriteLine("Types of calculation: " +"add or +, minus or -, multiply or *, divide or /.");
            var operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
            
            Console.WriteLine("This is your result: " + result);

        }
    }
}