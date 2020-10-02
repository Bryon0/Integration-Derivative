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
            int a = 0;
            int b = 10;
            //Number of divisions of the integral
            int interval = 10;

            //Value along the x axis
            double x = 0;
            //Sum of the addition process
            double sum = 0;
            //Delta x for the trapezoid method.
            double deltaX = (b - a) / (double)interval; 

            for(int i = 0; i <= b; i++)
            {
                if(i == 0 || i == b)
                {
                    sum += Function(x);
                }
                else
                {
                    sum += 2*(Function(x));
                }
                x += ((double)b/(double)interval);
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
