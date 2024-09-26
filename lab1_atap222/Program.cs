using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_atap222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int k = 1; k <= 99; k++)
            {
                if (k % 100 >= 11 && k % 100 <= 19)
                {
                    Console.WriteLine($"Менi {k} рокiв");
                }
                else
                {
                    int lastNumber = k % 10;

                    if (lastNumber == 1)
                    {
                        Console.WriteLine($"Менi {k} рiк");
                    }
                    else if (lastNumber >= 2 && lastNumber <= 4)
                    {
                        Console.WriteLine($"Менi {k} роки");
                    }
                    else
                    {
                        Console.WriteLine($"Менi {k} рокiв");
                    }
                }
            }

        }
    }
}
