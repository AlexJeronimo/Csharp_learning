namespace C_ArraysCollections
{
    class Program
    {
        private static void Main(string[] args)
        {
            
        }
        static void NonStandardArrayIndex()
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2023, 1);
            myArray.SetValue(2024, 2);
            myArray.SetValue(2025, 3);
            myArray.SetValue(2026, 4);

            Console.WriteLine($"Starting index {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index {myArray.GetUpperBound(0)}");

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
        }
        static void JaggedArray()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Enter the numbers for jagged array.");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine()!;
                    jaggedArray[i][j] = int.Parse(st);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Printing the elements");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MultiDimentionalArray()
        {
            //1 2 3 4

            //1 2 3
            //4 5 6
            //7 8 9

            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void StackQueueDemo()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out 4: {stack.Peek()}");

            Console.WriteLine($"Deleting item. Should print out 4(element which deleted): {stack.Pop()}");
            Console.WriteLine($"Should print out 3, after delete operation: {stack.Peek()}");

            Console.WriteLine("Iterate over the stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Should print out 1: {queue.Peek()}");

            queue.Dequeue();
            Console.WriteLine($"Should print out 2, after delete operation: {queue.Peek()}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
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
