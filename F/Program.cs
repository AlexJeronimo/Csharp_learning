namespace F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address addr = new();
            Console.WriteLine(addr.Country);


            Rectangle rec = new(12, 8);

            Console.WriteLine(rec.Area);
            Console.WriteLine(rec.Perimeter);

            string content = "Because I do not have money to get good programming course I must use this tutorial hell and learn diferent thins on my own";
            Book book = new("C# learning tutorial hell", "Bunch of Different", content);
            book.Show();

            Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));

            Console.WriteLine($"P = {figure.Type}");

            figure.PerimeterCalculator();
        }
    }
}
