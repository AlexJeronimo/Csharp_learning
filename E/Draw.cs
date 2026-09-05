using System;
using System.Collections.Generic;
using System.Text;

namespace E
{
    internal class Draw
    {
        public void Rectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        public void Triangle(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }


        public void Triangle(int height, int width )
        {

            int z = 1;
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }

                width -= 1;
                z += 2;
                Console.Write("\n");
            }
        }


        public void Result(int a, int b)
        {
            int result = 0;

            for ( ; a < b; a++)
            {
                if ((a % 2) != 0)
                {
                    Console.WriteLine($"{a}");
                }
                result += a;
            }

            Console.WriteLine($"Sum numbers is {result}");
        }

    }
}
