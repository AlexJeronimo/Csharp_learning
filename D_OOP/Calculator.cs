using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {
        public double GetTriangleArea(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        public double GetTriangleArea(double b, double h)
        {
            return 0.5 * b * h;
        }

        public double GetTriangleArea(double ab, double ac, int alpha)
        {
            double rads = alpha + Math.PI / 180;
            return 0.5 * ab * ac * Math.Sin(rads);
        }

        public double Average(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }

        public double Average2(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }
    }
}
