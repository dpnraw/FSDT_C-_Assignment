using System.Drawing;

namespace array_exercises
{
    class Program
    {
        //Entry point of the program
        public static void Main(String[] args)
        {
            // get number of circles from user
            Console.WriteLine("Enter the number of circles you want to create.");
            int numberOfCircle = int.Parse(Console.ReadLine());

            // array of cricle from circle class
            Circle[] circles = new Circle[numberOfCircle];

            // iterate through array items
            for (int i = 0; i < numberOfCircle; i++)
            {
                // get radius for each circle object
                Console.WriteLine($"Enter the radius for circle {i + 1}:");
                double radius = double.Parse(Console.ReadLine());

                // get x,y point 
                Console.WriteLine($"Enter the X coordinate for the center of circle {i + 1}:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the Y coordinate for the center of circle {i + 1}:");
                double y = double.Parse(Console.ReadLine());

                // Create a new Circle object and add it to the array
                circles[i] = new Circle(radius, new Point(x, y));
            }

            // Loop to print the perimeter and surface of each circle
            foreach (var circle in circles)
            {
                Console.WriteLine($"Circle with radius {circle.Radius} has a perimeter of {circle.CalculatePerimeter():F2} and a surface of {circle.CalculateSurface():F2}");
            }

            // Prompt the user for a point to check against the circles
            Console.WriteLine("Enter a point to check (X):");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a point to check (Y):");
            double y1 = double.Parse(Console.ReadLine());

            // create a point class object 
            Point userPoint = new Point(x1, y1);

            // Loop to check if the user's point is inside each circle
            for (int i = 0; i < circles.Length; i++)
            {
                bool isInside = circles[i].ContainsPoint(userPoint);
                Console.WriteLine($"Point ({userPoint.X}, {userPoint.Y}) is {(isInside ? "inside" : "outside")} circle {i + 1}");
            }

            Console.ReadKey();

        }
    }
}


