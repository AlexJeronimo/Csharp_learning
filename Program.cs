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
        static void IncrementDecrementDemo()
        {
            int x = 1;
            x = x + 1;
            Console.WriteLine(x);
            x++; //postfix
            Console.WriteLine(x);
            ++x; //infix/prefix
            Console.WriteLine(x);
            x = x - 1;
            Console.WriteLine(x);
            x--;
            Console.WriteLine(x);
            --x;
            Console.WriteLine(x);

            Console.WriteLine("Learn about increments");
            Console.WriteLine($"Last x state is {x}");

            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2;
            //x = x + 2;
            j -= 2;
            //j = j - 2;
        }
        static void MathOperations()
        {
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = z * 2;
            int c = k / 2;
            Console.WriteLine(b);
            Console.WriteLine(c);

            a = 4 % 2;
            b = 5 % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            b = 3;
            a = a * a;
            b = b * b * b;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 2 + 2 * 2;
            Console.WriteLine(a);

            a = (2 + 2) * 2;
            Console.WriteLine(a);

            a *= 2;
            //a = a * 2;

            a /= 2;
            //a = a / 2;
        }
        static void ComparisonOperators()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            bool result = x > y;
            Console.WriteLine(result);
            result = x >= y;
            Console.WriteLine(result);
            result = x < y;
            Console.WriteLine(result);
            result = x <= y;
            Console.WriteLine(result);
            result = x != y;
            Console.WriteLine(result);
        }
        static void StaticNAdInstancveMembers()
        {
            string name = "abracadabra";
            //string name = new string("abracadabra");
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(x);
            Console.WriteLine(xStr);
        }
        static void QueryingStrings()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexOfA = name.IndexOf('a', 1); //3 indexing starts from 0
            Console.WriteLine(indexOfA);
            int lastIndexOfR = name.LastIndexOf('r'); //9
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length); //11 length is the number of characters in string

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 3);

            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFromTo);
        }
        static void StringEmptines()
        {
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);


            Console.WriteLine("IsNullOrWhiteSpace");
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpace);
        }
    }
}