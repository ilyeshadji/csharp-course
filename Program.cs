using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;


namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // How to declare a list
            List<string> list = new List<string>();

            // Add
            list.Add("yellow");
            list.Add("blue");
            list.Add("green");

            // Accessing list items
            foreach (string color in list)
            {
                System.Console.WriteLine(color);
            }
        }
    }
}
