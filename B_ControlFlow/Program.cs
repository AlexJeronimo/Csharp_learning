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

