using System;

namespace TrapezoidRule
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finite integral
            double lowerLimit = 0;
            double upperLimit = Math.PI;
            //Number of divisions of the integral
            uint interval = 100;

            Console.WriteLine($"Trapezoid rule: {TrapezoidRule(lowerLimit, upperLimit, interval, function)}");
            Console.WriteLine($"Simpsons rule: {SimpsonsRule(lowerLimit, upperLimit, interval, function)}");
            Console.WriteLine($"Derivative at 1 is {Derivative(1, 0.00001, function)}");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lowerLimit"></param>
        /// <param name="upperLimit"></param>
        /// <param name="interval"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static double TrapezoidRule(double lowerLimit, double upperLimit, uint interval, Func<double, double> func)
        {
            //Value along the x axis
            double x = 0;
            //Sum of the addition process
            double sum = 0;

            //Create and add up all of the trapezoids.
            for(int i = 0; i <= interval; i++)
            {
                sum = (i == 0 || i == interval) ? sum += func(x) : sum += 2*func(x);
                x += (upperLimit/(double)interval);
            }

            return (((upperLimit - lowerLimit) / (double)interval)/2) * sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lowerLimit"></param>
        /// <param name="upperLimit"></param>
        /// <param name="interval"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static double SimpsonsRule(double lowerLimit, double upperLimit, uint interval, Func<double, double> func)
        {
            //Value along the x axis
            double x = 0;
            //Sum of the addition process
            double sum = 0;

            //Create and add up all of the trapezoids.
            for(int i = 0; i <= interval; i++)
            {
                //The simpsons rule should alternate between 2 (even) and 4 (odd)
                sum = (i == 0 || i == interval) ? sum += func(x) :  (i % 2 == 0) ?  sum += 2*func(x) : sum += 4*func(x);
                x += (upperLimit/(double)interval);
            }

            return (((upperLimit - lowerLimit) / (double)interval)/3) * sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static double function(double x)
        {
            //return Math.Pow(x, 2);
            //return Math.Sin(x);
            return Math.Pow(x, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="h"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        private static double Derivative(double x, double h, Func<double, double> func)
        {
            return (func(x + h) - func(x)) / h;
        }
    }
}
