using System;
using System.Collections.Generic;
using System.Text;

namespace F
{
    internal class Point
    {

        public int X { get; }
        public int Y { get; }
        string Name { get; }

        public Point(string name, int a, int b)
        {
            Name = name;
            X = a;
            Y = b;
        }


    }
}
