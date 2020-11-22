using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Line Comparison Computation Program");
            int x1, x2,x3,x4, y1, y2,y3,y4;

            Console.WriteLine("Enter the Values of x1 and y1 Co-ordinates");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Values of x2 and y2 Co-ordinates");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            double line_One_Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of line One is : " + line_One_Length);

            Console.WriteLine("Enter the Values of x3 and y3 Co-ordinates");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Values of x4 and y4 Co-ordinates");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());

            double line_Two_Length = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of line Two is : " + line_Two_Length);

            double differenceInLengths = line_One_Length.CompareTo(line_Two_Length);
            Console.WriteLine("Difference Between two Lengths is:" + differenceInLengths);

            if (differenceInLengths == 0)
            {
                Console.WriteLine("Length of Two Lines are Equal");
            }
            else if(differenceInLengths < 0)
            {
                Console.WriteLine("Length of Line One is less than Length of Line Two");
            }
            else
            {
                Console.WriteLine("Length of Line One is greater than Length of Line Two");
            }
        }
    }
}
