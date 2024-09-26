using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_atap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть Х = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y, a, b;
            a = 2.8;
            b = -0.3;
            if (x < 1.2)
                y = a * Math.Pow(x,2) + b * x;
            else if (x == 1.2)
            {
                y = a/x + Math.Sqrt(Math.Pow(x, 2) + 1);
            }
            else
            {
                y = (a+b*x)/Math.Sqrt(Math.Pow(x, 2) + 1);
            }
            Console.Write(y);
            Console.ReadKey();

        }
    }
}
