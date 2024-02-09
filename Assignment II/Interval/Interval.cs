using System;

namespace Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // user input
                Console.WriteLine("Enter a real number:");
                double x = Convert.ToDouble(Console.ReadLine());

                // Test the membership of x to the set I
                if (!(x < 2 || x > 3) && (!(x < -10) || !(x > -2)))
                {
                    Console.WriteLine($"{x} belongs to I");
                }
                else
                {
                    Console.WriteLine($"{x} does not belong to I");
                }

                // exit if user enterd no
                Console.WriteLine("Do you want to check more numbers ('Y/N') ???");
                string ans = Console.ReadLine();
                if (ans == "N")
                {
                    break;
                }
            }
        }
    }
}