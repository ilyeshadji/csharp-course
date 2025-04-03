using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int sum;

            System.Console.Write("Enter the first whole number: ");
            firstNumber = int.Parse(Console.ReadLine());

            System.Console.Write("Enter the second whole number:");
            secondNumber = int.Parse(Console.ReadLine());

            sum = firstNumber + secondNumber;

            // String concatenation
            Console.WriteLine("The sum is: " + sum);

            // String interpolation
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
