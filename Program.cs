using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            double sum;

            System.Console.Write("Enter the first number: ");
            firstNumber = double.Parse(Console.ReadLine());

            System.Console.Write("Enter the second number: ");
            secondNumber = double.Parse(Console.ReadLine());

            // Rounding to two decimal place
            sum = Math.Round(firstNumber + secondNumber, 2);

            // String concatenation
            Console.WriteLine("The sum is: " + sum);

            // String interpolation
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
