using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Line Comparison Computation Program");
            int x1, x2, y1, y2;

            Console.WriteLine("Enter the Values of x1 and y1 Co-ordinates");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Values of x2 and y2 Co-ordinates");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of line is : " + length);
        }
    }
}
