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
            int a = 0;
            int b = 10;
            int interval = 10;
            double sum = 0;
            double deltaX = (b - a) / interval; 
            double intervaldivision = b / interval;

            Console.WriteLine($"{(deltaX/2) * sum} {Environment.NewLine}");

            sum = 0;
            for(int i = 0; i <= b; i++)
            {
                if(i == 0 || i == b)
                {
                    //Console.WriteLine($"{a} {b} {i} {Function(i)} {Environment.NewLine}");
                    sum += Function(i);
                }
                else
                {
                    //Console.WriteLine($"{a} {b} {i} {Function(i)} {Environment.NewLine}");
                    sum += 2*(Function(i));
                }

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
