using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of X:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of Y:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Before Swapping: X= {x} ; Y = {y}");
        (x,y) = (y,x); // varibale swapping

        Console.WriteLine($"After Swapping: X = {x} ; Y = {y}");
        Console.ReadKey();
    }
}
