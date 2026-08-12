namespace D_OOP
{
    class Program
    {
        private static void Main(string[] args)
        {
            IBaseCollection collection = new BaseList(4);
            collection.Add(1);

        }

        static void Do(Shape shape)
        {
            shape.Draw();
        }

        static void PolimorphismDemo()
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
                Console.WriteLine(shape.Area());
            }
        }
        static void InheritanceDemo()
        {
            ModelXTerminal terminal = new ModelXTerminal("123");
            terminal.Connect();
        }
        static void ClassesMethods()
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

            //Console.WriteLine("Struct");
            //PointVal a; // same as Point a = newPointVal();

            //a.x = 3;
            //a.y = 5;

            //PointVal b;
            //b.x = 7;
            //b.y = 10;

            //a.LogValue();
            //b.LogValue();

            //Console.WriteLine("Class");
            //PointRef c = new PointRef();
            //c.x = 3;
            //c.y = 5;

            //PointRef d = c;
            //d.x = 7;
            //d.y = 10;

            //c.LogValue();
            //d.LogValue();

            //EvilStruct es1 = new EvilStruct();
            //es1.PointRef = new PointRef() { x = 1, y = 2};
            ////es1.PointRef.x = 1;
            ////es1.PointRef.y = 2;
            //EvilStruct es2 = es1;

            //Console.WriteLine($"es1.PointRef.X={es1.PointRef.x}, es1.Pointref.Y={es1.PointRef.y}");
            //Console.WriteLine($"es2.PointRef.X={es2.PointRef.x}, es2.Pointref.Y={es2.PointRef.y}");

            //es2.PointRef.x = 42;
            //es2.PointRef.y = 45;

            //Console.WriteLine($"es1.PointRef.X={es1.PointRef.x}, es1.Pointref.Y={es1.PointRef.y}");
            //Console.WriteLine($"es2.PointRef.X={es2.PointRef.x}, es2.Pointref.Y={es2.PointRef.y}");

            //var list  = new List<int>();
            //AddNumbers(list);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //int a = 1;
            //int b = 2;
            //Swap(ref a, ref b);

            //Console.WriteLine($"a={a}, b={b}");

            //PointVal? pv = null;
            //if (pv.HasValue)
            //{
            //    PointVal pv2 = pv.Value;
            //    Console.WriteLine(pv2.x);
            //    Console.WriteLine(pv.Value.x);
            //}
            //else
            //{
            //    //
            //}

            //PointVal ps3 = pv.GetValueOrDefault();


            //PointRef c = null;
            //Console.WriteLine(c.x); //NullReferenceException

            Character c = new Character("Elf");
            Console.WriteLine(c.Race);

            Character c2 = new Character();

            Student student = new Student("Qwertysh", new DateTime(2000, 10, 5));
            Student student2 = student;
            Student student3 = new Student(student);

            student.SetLastName("######");

            student.Print();

            Console.WriteLine();

            student2.Print();
            Console.WriteLine();

            student3.Print();


            Point p = new Point();

            p.Y = 10;

            int y = p.Y;
        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Swapped a={a}, b={b}");
        }

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
    }
}