namespace D_OOP
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Character c = new Character();

            //c.Hit(120);

            //Console.WriteLine(c.Health);


            //Calculator calc = new Calculator();

            //if(calc.TryDivide(10, 2, out double result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to divide");
            //}
            //Console.ReadLine();

            //double area1 = calc.GetTriangleArea(2, 8);
            //double area2 = calc.GetTriangleArea(20, 21, 28);

            //Console.WriteLine(area1);
            //Console.WriteLine(area2);

            //double avg = calc.Average(new int[] { 1, 2, 3, 4 });
            //Console.WriteLine(avg);

            //double avg2 = calc.Average2(1, 2, 3, 4);
            //Console.WriteLine(avg2);

            //Console.WriteLine("Enter a number, please.");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);

            //string line = Console.ReadLine();
            //int number;
            //bool wasParsed = int.TryParse(line, out int number);
            //if (wasParsed)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to parse");
            //}

            //double avg = Calculator.Average2(1, 2, 3, 4, 5);
            //Console.WriteLine(avg);

            //Character c1 = new Character();
            //Character c2 = new Character();

            //Console.WriteLine($"c1.Speed={c1.PrintSpeed()}. c2.Speed={c2.PrintSpeed()}");
            //c1.IncreaseSpeed();
            //Console.WriteLine("After c1 speed increased");
            //Console.WriteLine($"c1.Speed={c1.PrintSpeed()}. c2.Speed={c2.PrintSpeed()}");

            Console.WriteLine("Struct");
            PointVal a; // same as Point a = newPointVal();
            
            a.x = 3;
            a.y = 5;

            PointVal b;
            b.x = 7;
            b.y = 10;

            a.LogValue();
            b.LogValue();

            Console.WriteLine("Class");
            PointRef c = new PointRef();
            c.x = 3;
            c.y = 5;

            PointRef d = c;
            d.x = 7;
            d.y = 10;

            c.LogValue();
            d.LogValue();
        }
    }
}