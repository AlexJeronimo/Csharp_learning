using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public abstract class Shape
    {
        protected Shape()
        {
            Console.WriteLine("Shape created");
        }
        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimeter();
    }


    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;

            Console.WriteLine("Triangle created.");
        }

        public override double Area()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s* (s- ab) * (s - bc) * (s -ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Perimeter()
        {
            return ab + bc + ac;
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle created.");
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle.");
        }

        public override double Perimeter()
        {
            return 2 * (height + width);
        }
    }

}
