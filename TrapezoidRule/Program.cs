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
                    sum += Function(x);
                }
                else
                {
                    sum += 2*(Function(x));
                }
                x += (upperLimit/(double)interval);
            }

            Console.WriteLine($"{(deltaX/2) * sum} {Environment.NewLine}");
            Console.ReadKey();

        }

        private static double Function(double x)
        {
            return Math.Pow(x, 2);
        }
    }
}
