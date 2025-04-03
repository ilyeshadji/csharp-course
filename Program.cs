using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using CSharpMasterclass;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer();

            System.Console.WriteLine("C1: " + c1.Id);
            System.Console.WriteLine("C2: " + c2.Id);

        }
    }
}
