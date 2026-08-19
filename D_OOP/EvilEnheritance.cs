using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{

    public interface IShape
    {
        int CalcSquare();
    }

    public class Rect : IShape
    { 
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcSquare()
        {
            return Height * Width;
        }
    }

    public class Square : IShape
    {
        public int sideLength { get; set; }
        public int CalcSquare()
        {
            return sideLength * sideLength;
        }
    }

    //public static class AreaCalculator
    //{
    //    public static int CalcSquare(Square square)
    //    {
    //        return square.Height * square.Width;
    //    }

    //    public static int CalcSquare(Rect rect)
    //    {
    //        return rect.Height * rect.Width;
    //    }
    //}

}
