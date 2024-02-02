using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age;
        bool success = int.TryParse(Console.ReadLine(), out age);

        if (success)
        {
            int currentYear = DateTime.Now.Year;
            int yearOfBirth = currentYear - age;

            Console.WriteLine($"Your year of birth is: {yearOfBirth}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for your age.");
        }
    }
}