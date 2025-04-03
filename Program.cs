using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            string inputString = Console.ReadLine();

            int num1;

            bool isNumber = int.TryParse(inputString, out num1);

            if (!isNumber)
            {
                System.Console.WriteLine("You trolled! You should enter a number");
            }
            else
            {
                num1++;

                Console.WriteLine("User entered number +1 " + num1);
            }


        }
    }
}
