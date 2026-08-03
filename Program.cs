using System;
using System.Text;

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

            string str = string.Empty;
            //string str = "";
            Console.WriteLine(str);

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
        static void StringModification()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "Alex");
            Console.WriteLine(nameConcat);
            nameConcat = string.Join(" ", "My", "name", "is", "Alex");
            Console.WriteLine(nameConcat);

            //string newName = 
            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            string data = "12;38;43;32;19";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);
        }
        static void StringBuildferDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Alex");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }
        static void StringFormat()
        {
            string name = "Alex";
            int age = 38;
            string str1 = string.Format("My name is {0} and I'm {1}.", name, age);
            string str2 = "My name is " + name + " and I'm " + age + ".";
            string str1_2 = $"My name is {name} and I'm {age}.";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str1_2);

            string str3 = "My name is \nAlex";
            string str4 = "I am \t38.";
            Console.WriteLine(str3);
            Console.WriteLine(str4);

            str3 = $"My name is {Environment.NewLine}Alex"; //\t
            Console.WriteLine(str3);

            string str5 = "I'm John and I'm \"good\" programmer";
            Console.WriteLine(str5);

            string str6 = "C:\\tmp\\test\\file.txt";
            Console.WriteLine(str6);
            string str6_1 = @"C:\tmp\test\file.txt";
            Console.WriteLine(str6_1);

            Console.WriteLine();

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            result = string.Format("{0:f}", answer);
            result2 = string.Format("{0:f4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            double answer2 = 42.08;

            result = string.Format("{0:f}", answer2);
            result2 = string.Format("{0:f1}", answer2);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money); // C - currency, get your system cyrrency to output its sign
            result2 = string.Format("{0:C4}", money);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(money.ToString("C2"));
            result = $"{money:C2}";
            Console.WriteLine(result);
        }
        static void ComparingStrings()
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);

            Console.WriteLine();

            string s1 = "Strasse";
            string s2 = "Straße";
            areEqual = string.Equals(s1, s2, StringComparison.Ordinal); //use by default
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
        }
        static void ConsoleBasics()
        {
            //Console.WriteLine("Hi, please tell me your name: ");
            //string name = Console.ReadLine();
            //string sentance = $"Your name is {name}";
            //Console.WriteLine(sentance);

            Console.WriteLine("Hi, tell em your age: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            string sentance = $"Your age is {age}";
            Console.WriteLine(sentance);


            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("New Style");
        }
        static void CastingAndParsing()
        {
            byte b = 3; // 0000 0011
            int i = b; //  0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            Console.WriteLine(b);
            Console.WriteLine(i);
            Console.WriteLine(l);

            float f = i; // 3.0
            Console.WriteLine(f);

            b = (byte)i;
            Console.WriteLine(b);

            i = (int)f;
            Console.WriteLine(i);
            Console.WriteLine();

            string str = "1";
            i = int.Parse(str);
            Console.WriteLine(i);
            Console.WriteLine();

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            double result2 = (double)x / 2;
            Console.WriteLine(result2);
        }
        static void Comments()
        {
            // a single line comment

            /*
             * Multi
             * line
             * comment
             * 
             */

            //describe how and why! not describe whats!

            int a = 1;
            //incremet a by 1 - bad comment! this code is self-evident

            //we need to tweak the index to mathc the expected outcome - good comment!
            a++; // not recommended to set comments in the code line, better is to do it abow the code line!
        }
        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));
            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine(Math.Round(1.5));
            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5));

            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
        }
        void IntroToArrays()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a4 = { 1, 2, 3, 4, 11 };

            Console.WriteLine(a4[0]);
            int number = a4[3];
            Console.WriteLine(number);
            a4[3] = 7;
            Console.WriteLine(a4[3]);

            Console.WriteLine(a4.Length);

            Console.WriteLine(a4[a4.Length - 1]);

            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine(first);
            Console.WriteLine(last);
        }
        void DateTimeIntro()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine($"It's {now.ToShortDateString()}, {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDt = dt.AddDays(1);
            DateTime newDt2 = dt.AddDays(2);
            Console.WriteLine(newDt);
            Console.WriteLine(newDt2);

            Console.WriteLine();

            TimeSpan ts = now - dt;
            Console.WriteLine(ts.Days);
            ts = now.Subtract(dt);
            Console.WriteLine(ts.Days);
        }
        void HW1()
        {
            Console.WriteLine("Enetr your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");

            Console.WriteLine("PLease neter 2 numbers: ");
            Console.WriteLine("Number 1: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"X: {x}, Y: {y}");
            int c = x;
            x = y;
            y = c;
            Console.WriteLine($"X: {x}, Y: {y}");

            Console.WriteLine("Enetr number: ");
            string l = Console.ReadLine();
            Console.WriteLine($"Number length : {l.Length}");
        }
        void HW2RectangleArea()
        {
            Console.WriteLine("Enter length of first side of triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of second side of triangle: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of third side of triangle: ");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Triangle area: {S}");
        }
        void HW3BMI()
        {
            Console.WriteLine("Eneter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Eneter your last surname: ");
            string sn = Console.ReadLine();

            Console.WriteLine("Eneter your age: ");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Enetr your weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enetr your height in meters");
            double height = double.Parse(Console.ReadLine());
            double imt = weight / (height * height);

            Console.WriteLine("=====Your Profile=====");
            Console.WriteLine($"Full Name: {sn}, {name}");
            Console.WriteLine($"Age: {age} years");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Height: {height} m");
            Console.WriteLine($"Body Mass Index: {imt:f2}");
        }
    }
}