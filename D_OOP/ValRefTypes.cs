using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public struct PointVal
    {
        public int x;
        public int y;

        public void LogValue()
        {
            Console.WriteLine($"x={x}; y={y}");
        }
    }

    public class PointRef
    {
        public int x;
        public int y;

        public void LogValue()
        {
            Console.WriteLine($"x={x}; y={y}");
        }
    }
}
