using System;

class Program
{
    static void Main()
    {
        double a = 1;
        double b = -3;
        double c = 2;

        double[] solutions = new double[2];

        
        SolveQuadratic(a, b, c, solutions);

       
        Console.WriteLine("x1 = " + solutions[0]);
        Console.WriteLine("x2 = " + solutions[1]);
    }

    static void SolveQuadratic(double a, double b, double c, double[] solutions)
    {
        
        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            throw new Exception("No real solutions");
        }

       
        double sqrtDiscriminant = Math.Sqrt(discriminant);

        
        solutions[0] = (-b + sqrtDiscriminant) / (2 * a);
        solutions[1] = (-b - sqrtDiscriminant) / (2 * a);
    }
}
