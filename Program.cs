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
            Car car1 = new Car("mything", true);

            car1.Model = Console.ReadLine();
            System.Console.WriteLine("Car model: " + car1.Model);
        }
    }
}
