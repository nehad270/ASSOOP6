using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSOOP6
{
    internal class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return double.NaN;
            }
            return (double)a / b;
        }
    }
}
