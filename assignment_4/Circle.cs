using System;
namespace array_exercises
{
    // Circle class
    public class Circle
    {
        // Property for the radius of the circle
        private double radius;

        // Property for the center of the class
        public Point Center { get; private set; }

        // accessor for radius
        public double Radius
        {
            get { return radius; }
        }

        // constructor to initialize object
        public Circle(double radius, Point Center)
        {
            this.radius = radius;
            this.Center = Center;
        }



        public double CalculateSurface()
        {
            // Calculate the surface area of the circle
            double surfaceArea = Math.PI * Math.Pow(radius, 2);
            return surfaceArea;
        }

        public double CalculatePerimeter()
        {
            // Calculate the perimeter of the circle
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }

        // Method to determine if a given point is inside the circle
        public bool ContainsPoint(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2));
            return distance <= Radius;
        }

    }

    // Define a Point class to represent a point in 2D space
    public class Point
    {
        // Properties for the X and Y coordinates
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor to create a point with specific X and Y coordinates
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}


