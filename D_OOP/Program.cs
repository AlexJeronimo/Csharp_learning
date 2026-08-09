namespace D_OOP
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Character c = new Character();
            
            //c.Hit(120);
            
            //Console.WriteLine(c.Health);


            Calculator calc = new Calculator();
            //double area1 = calc.GetTriangleArea(2,8);
            //double area2 = calc.GetTriangleArea(20,21,28);

            //Console.WriteLine(area1);
            //Console.WriteLine(area2);

            double avg = calc.Average(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(avg);

        }
    }
}