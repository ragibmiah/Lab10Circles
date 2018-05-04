using System;

namespace Lab10Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            bool success = true;
            int count = 0;

            while (success)
            {
                Console.Write("Please enter a radius: ");
                string input = Console.ReadLine();

                //double PI;
                double num;
                double.TryParse(input, out num);
                if (num > 0)
                {
                    Circles circleone = new Circles(num);
                    Console.Write($"Circumference: ");
                    Console.WriteLine(circleone.CalculateFormattedCircumference());
                    Console.Write($"Area: ");
                    Console.WriteLine(circleone.CalculateFormattedArea());
                    count++;

                    Console.WriteLine("Continue? Enter y to continue, any other key exits.");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "y")
                    {
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine($"You created {count} circle objects");
                        success = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    success = true;
                }
            }
        
        }
    }
}
