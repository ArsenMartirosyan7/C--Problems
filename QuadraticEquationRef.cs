using System;

class Program
{
    static void Main()
    {
        double a = 1;
        double b = -3;
        double c = 2;
        double x1, x2;


        SolveQuadratic(a, b, c, out x1, out x2);

        
        Console.WriteLine("x1 = " + x1);
        Console.WriteLine("x2 = " + x2);
    }

    static void SolveQuadratic(double a, double b, double c, out double x1, out double x2)
    {
        
        double discriminant = b * b - 4 * a * c;

        
        if (discriminant < 0)
        {
            throw new Exception("No real solutions");
        }

        
        double sqrtDiscriminant = Math.Sqrt(discriminant);

       
        x1 = (-b + sqrtDiscriminant) / (2 * a);
        x2 = (-b - sqrtDiscriminant) / (2 * a);
    }
}
