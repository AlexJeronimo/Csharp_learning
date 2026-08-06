namespace C_ArraysCollections
{
    class Program
    {
        private static void Main(string[] args)
        {
            
        }

        static void DictiomaryDemo()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");


            people = new Dictionary<int, string>()
            {
                { 4, "Mike" },
                { 5, "Julia" },
                { 6, "Fred" },
            };


            string name = people[5];
            Console.WriteLine(name);

            var keys = people.Keys;

            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(people.Count);
            var values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var pair in people)
            {
                Console.WriteLine($"Key:{pair.Key}. Value:{pair.Value}");
            }
            Console.WriteLine();


            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("Mila");

            bool removed = people.Remove(1);

            if (people.TryAdd(2, "Eliza"))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Fail to add using key 2");
            }

            if (people.TryGetValue(3, out var val))
            {
                Console.WriteLine($"Key 3, Val{val}");
            }
            else
            {
                Console.WriteLine("Failed to get value by key 3");
            }

            people.Clear();
        }
        static void ListDemo()
        {
            var intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 2, 9, 12 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3, };
            intList.AddRange(intArray);

            if (intList.Remove(1)) //first occurence
            {
                //do
            }
            else { }

            intList.RemoveAt(0);
            intList.Reverse();

            bool contains = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min={min}. Max={max}");

            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine();

            foreach (int item in intList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void ArrayType()
        {
            int[] a = new int[5];

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            //all 3 the same

            myArray2.SetValue(12, 0);
            Console.WriteLine(myArray2.GetValue(0));

            Console.WriteLine();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            Console.WriteLine();

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);
            foreach (int n in copy)
                Console.Write(n + " ");

            Console.WriteLine();

            int[] copy2 = new int[10];
            copy.CopyTo(copy2, 0);
            foreach (int n in copy2)
                Console.Write(n + " ");

            Console.WriteLine();

            Array.Reverse(copy);
            foreach (int n in copy)
                Console.Write(n + " ");

            Console.WriteLine();

            Array.Sort(copy);
            foreach (int n in copy)
                Console.Write(n + " ");

            Console.WriteLine();

            Array.Clear(copy, 0, copy.Length);
            foreach (int n in copy)
                Console.Write(n + " ");
        }

    }
}
