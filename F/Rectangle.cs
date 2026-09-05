using System;
using System.Collections.Generic;
using System.Text;

namespace F
{
    internal class Rectangle
    {

        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        double AreaCalculator()
        {
            return SideA * SideB;
        }

        double PertimeterCalculator()
        {
            return 2 * (SideA + SideB);
        }

        public double Area
        {
            get => AreaCalculator();
        }

        public double Perimeter
        {
            get => PertimeterCalculator();
        }
    }
}
