using System;
using System.Collections.Generic;
using System.Text;

namespace E
{
    internal class Refs
    {
        public int Method(out int a)
        {
            a = 0;
            int b = a * 2;
            return b;
        }


        public void Calculate(int a, int b , int c)
        {
            double average = (double)(a + b + c) / 3;
            Console.WriteLine($"{average:F2}");
        }

    }
}
