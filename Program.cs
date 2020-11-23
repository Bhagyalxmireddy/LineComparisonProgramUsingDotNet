using System;

namespace LineComparison
{
    class Program
    {
        /// <summary>
        /// Calculating the lengths of lines
        /// </summary>
        /// <returns></returns>
        public  static double calculateLengthOfLines()
        {
            double Xpoints = distanceBetweenTwoPonits();
            double Ypoints = distanceBetweenTwoPonits();
            double length = Math.Sqrt(Xpoints + Ypoints);
            return length;
        }
        /// <summary>
        /// Take the two points of line and calculate distance and power of a points and return the value
        /// </summary>
        /// <returns></returns>
        public static double distanceBetweenTwoPonits()
        {
            Console.WriteLine("Enter the value of Co-ordinates a and b");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Pow(a - b, 2);
            return distance;
        }
           /// <summary>
        /// Compare Two Lines Lengths and print the Result
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Line Comparison Computation Program");
            double line_One_Length = calculateLengthOfLines();
            Console.WriteLine("Length of Line One is : " + line_One_Length);
            double line_Two_Length = calculateLengthOfLines();
            Console.WriteLine("Length of Line Two is : " + line_Two_Length);
            double differenceInLengths = line_One_Length.CompareTo(line_Two_Length);
            Console.WriteLine("distance between Two liens is :" +differenceInLengths);
            if (differenceInLengths == 0)
            {
                Console.WriteLine("Length of Two Lines are Equal");
            }
            else if (differenceInLengths == -1)
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
