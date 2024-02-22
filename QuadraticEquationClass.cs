using System;

class Program
{
    static void Main()
    {
        double a = 1;
        double b = -3;
        double c = 2;

     
        (double x1, double x2) = SolveQuadratic(a, b, c);

       
        Console.WriteLine("x1 = " + x1);
        Console.WriteLine("x2 = " + x2);
    }

    static (double, double) SolveQuadratic(double a, double b, double c)
    {
        
        double discriminant = b * b - 4 * a * c;

        
        if (discriminant < 0)
        {
            throw new Exception("No real solutions");
        }

        
        double sqrtDiscriminant = Math.Sqrt(discriminant);

        
        double x1 = (-b + sqrtDiscriminant) / (2 * a);
        double x2 = (-b - sqrtDiscriminant) / (2 * a);
        return (x1, x2);
    }
}
