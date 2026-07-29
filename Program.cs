using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            
            
        }

        static void Variables()
        {
            int x = -1;
            int y;
            y = 2;


            Console.WriteLine("x = {0}, y = {1}", Convert.ToString(x), Convert.ToString(y));
        }

        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10011001;
            int m = 0b1001_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine();

            x = 0x1F;
            y = 0xFF0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine();

            Console.WriteLine(4.5e2);
            Console.WriteLine(3.1E-1);
            Console.WriteLine();

            Console.WriteLine('\x78');
            Console.WriteLine('\x5A');
            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');
            Console.WriteLine();
        }

        static void Scope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c);
            }
            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
        }
        static void Overflow()
        {
            checked
            {
                uint x = uint.MaxValue;
                Console.WriteLine(x);
                x = x + 1;
                Console.WriteLine(x);
                x = x - 1;
                Console.WriteLine(x);
            }
        }
    }
}