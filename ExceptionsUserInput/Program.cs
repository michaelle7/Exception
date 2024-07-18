using System;

// exception class for invalid radius values
public class InvalidRadiusException : Exception
{
    public InvalidRadiusException() : base("Invalid radius: Radius must be greater than zero.")
    {
    }

    public InvalidRadiusException(double radius) : base($"Invalid radius: {radius} is not a valid radius. Radius must be greater than zero.")
    {
    }
}

// circle class
public class Circle
{
    public double Radius { get; private set; }

    // set the radius, throws InvalidRadiusException if the radius is invalid
    public void SetRadius(double radius)
    {
        if (radius > 0)
        {
            Radius = radius;
        }
        else
        {
            throw new InvalidRadiusException(radius);
        }
    }

    // ToString to display circle information
    public override string ToString()
    {
        return $"Circle with radius: {Radius}";
    }
}

// main class
public class Program
{
    public static void Main(string[] args)
    {
        // circle object
        Circle circle = new Circle();

        // radius input
        Console.WriteLine("Enter the radius of the circle:");

        try
        {
            // get user input and convert to double
            double radius = Convert.ToDouble(Console.ReadLine());

            // set the radius
            circle.SetRadius(radius);

            // circle information
            Console.WriteLine(circle.ToString());
        }
        catch (InvalidRadiusException e)
        {
            // exception message if radius is invalid
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            // invalid input
            Console.WriteLine("Invalid input: Please enter a numeric value for the radius.");
        }
    }
}
