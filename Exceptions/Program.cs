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
        // test positive number
        try
        {
            Circle circle1 = new Circle();
            circle1.SetRadius(2.0);
            Console.WriteLine(circle1.ToString());
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }

        // test negative number
        try
        {
            Circle circle2 = new Circle();
            circle2.SetRadius(-9.0);
            Console.WriteLine(circle2.ToString());
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }

        // test with a 0 radius
        try
        {
            Circle circle3 = new Circle();
            circle3.SetRadius(0.0);
            Console.WriteLine(circle3.ToString());
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}