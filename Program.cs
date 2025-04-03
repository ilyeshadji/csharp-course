using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string q1 = "What is the capital in Germany?";
            string a1 = "Berlin";

            string q2 = "What is 2+2";
            string a2 = "4";

            string q3 = "What color do you get by mixing blue and yellow";
            string a3 = "Green";

            int score = 0;

            System.Console.WriteLine(q1);
            string ua1 = Console.ReadLine();

            if (ua1.Trim().ToLower() == a1.ToLower())
            {
                System.Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                System.Console.WriteLine("Wrong. The correct answer was " + a1);
            }

            System.Console.WriteLine(q2);
            string ua2 = Console.ReadLine();

            if (ua2.Trim().ToLower() == a2.ToLower())
            {
                System.Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                System.Console.WriteLine("Wrong. The correct answer was " + a2);
            }

            System.Console.WriteLine(q3);
            string ua3 = Console.ReadLine();

            if (ua3.Trim().ToLower() == a3.ToLower())
            {
                System.Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                System.Console.WriteLine("Wrong. The correct answer was " + a3);
            }

            System.Console.WriteLine($"Quizz completed, you got a score of {score}/3");

            if (score == 3)
            {
                System.Console.WriteLine("Excellent! You got all the answers right!");
            }
            else if (score > 0)
            {
                System.Console.WriteLine("Good try! You'll get them next time");
            }
            else
            {
                System.Console.WriteLine("You should get back to study!");
            }

            Console.ReadKey();
        }
    }
}
