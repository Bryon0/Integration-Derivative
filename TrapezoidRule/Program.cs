using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidRule
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finite integral
            double lowerLimit = 0;
            double upperLimit = 10;
            //Number of divisions of the integral
            uint interval = 1000;

            //Value along the x axis
            double x = 0;
            //Sum of the addition process
            double sum = 0;
            //Delta x for the trapezoid method.
            double deltaX = (upperLimit - lowerLimit) / (double)interval; 

            for(int i = 0; i <= interval; i++)
            {
                if(i == 0 || i == interval)
                {
                    sum += function(x);
                }
                else
                {
                    sum += 2*(function(x));
                }
                x += (upperLimit/(double)interval);
            }

            Console.WriteLine($"{(deltaX/2) * sum} {Environment.NewLine}");
            Console.ReadKey();

            Console.WriteLine($"{TrapezoidRule(lowerLimit, upperLimit, interval, function)}");
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


        private static double function(double x)
        {
            return Math.Pow(x, 2);
        }
    }
}
