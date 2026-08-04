

static void WhileDoWhile()
{
    int age = 0;
    while (age < 18)
    {
        Console.WriteLine("First While loop");
        Console.WriteLine("What is your age: ");
        age = int.Parse(Console.ReadLine()!);
    }


    do
    {
        Console.WriteLine("Do\\While");
        Console.WriteLine("What is your age: ");
        age = int.Parse(Console.ReadLine()!);
    }
    while (age < 18);

    Console.WriteLine("Good!");

    int[] numbers = { 1, 2, 3, 4, 5 };
    int i = 0;
    while (i < numbers.Length)
    {
        Console.Write(numbers[i] + " ");
        i++;
    }
}
static void NestedFor()
{

    int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 1, 7 };

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            int atI = numbers[i];
            int atJ = numbers[j];

            if (atI + atJ == 0)
            {
                Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j}). Sum equal 0");
            }
        }
    }

    Console.WriteLine();

    for (int i = 0; i < numbers.Length - 2; i++)
    {
        for (int j = i + 1; j < numbers.Length - 1; j++)
        {
            for (int k = j + 1; k < numbers.Length; k++)
            {
                int atI = numbers[i];
                int atJ = numbers[j];
                int atK = numbers[k];

                if (atI + atJ + atK == 0)
                {
                    Console.WriteLine($"Triplets ({atI};{atJ};{atK}). Indexes ({i};{j};{k}). Sum equal 0");
                }
            }

        }
    }

}
static void ForForeach()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine();

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine();

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    Console.WriteLine();

    foreach (int val in numbers)
    {
        Console.Write(val + " ");
    }
    Console.WriteLine();
}
static void ControlFlowIFELSE()
{
    Console.WriteLine("Eneter your age: ");
    int age = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Enetr your weight in kilograms: ");
    double weight = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Enetr your height in meters");
    double height = double.Parse(Console.ReadLine()!);
    double imt = weight / (height * height);

    bool isTooLow = imt <= 18.5;
    bool isNormal = imt > 18.5 && imt < 25;
    bool isAboveNormal = imt >= 25 && imt <= 30;
    bool isTooFat = imt > 30;

    bool isFat = isAboveNormal || isTooFat;

    if (isFat)
    {
        Console.WriteLine("You'd better lose some weight");
    }
    else
    {
        Console.WriteLine("Oh, you're in a good shape");
    }

    if (isFat || isTooFat)
    {
        Console.WriteLine("Anyway it's time to get on diet");
    }

    //ternary operation
    string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";
    Console.WriteLine(description);

    //the same in if-else construction
    if (age > 18)
    {
        description = "You can drink alcohol";
    }
    else
    {
        description = "You should get a bit older";
    }
    Console.WriteLine(description);


}
static void HW2Max()
{
    Console.WriteLine("Please neter 2 numbers:");
    Console.WriteLine("Fist number");
    int a = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Second number");
    int b = int.Parse(Console.ReadLine()!);

    string max = a > b ? $"A is max {a}" : $"B is max {b}";
    Console.WriteLine(max);
}