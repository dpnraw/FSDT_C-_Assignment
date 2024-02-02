using System;

class Degree3
{
    static void Main()
    {
        // Prompt the user to enter values for a, b, and c
        Console.Write("Enter a (int): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b (int): ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter c (int): ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter a value for x
        Console.Write("Enter x (double): ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Calculate the value of the polynomial
        double part1 = (a + b) / 2.0;
        double part2 = part1 * x;
        double part3 = (a + b) * x * x;
        double part4 = c * x * x * x;
        double result = part2 + part3 + part4;

        // Display the result
        Console.WriteLine("The value of the polynomial is: " + result);

        Console.ReadKey();
    }
}