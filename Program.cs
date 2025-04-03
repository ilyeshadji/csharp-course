using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 10;
            double price = 10.50;
            string name = "Frank";

            // concatenation
            System.Console.WriteLine("The number is " + num + ", the price is " + price + ", with name " + name);

            // interpolation
            System.Console.WriteLine($"The number is {num}, the price is {price}, with name {name}");

            // formatting
            System.Console.WriteLine("The number is {0}, the price is {1}, with name {2}", num, price, name);
        }
    }
}
