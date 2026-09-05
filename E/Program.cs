using System;


namespace E
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hey");
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Div(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                return a / b;
            }
            return 0;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        } 

    }
}
