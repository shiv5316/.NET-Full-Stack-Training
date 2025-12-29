<<<<<<< HEAD
<<<<<<< HEAD
using System;
using System.Collections;
using System.Collections.Generic;

class Program3
{
    public static void calculate()
    {
        Console.WriteLine("\nTASK 1:");

        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int val;
            do
            {
                Console.Write($"Enter price of product {i + 1}: ");
                val = int.Parse(Console.ReadLine());
            } while (val <= 0);

            prices[i] = val;
            sum += val;
        }

        double avg = (double)sum / n;
        Console.WriteLine("Average Price = " + avg);

        Array.Sort(prices);

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < avg)
                prices[i] = 0;
        }

        int oldLength = prices.Length;
        Array.Resize(ref prices, oldLength + 5);

        for (int i = oldLength; i < prices.Length; i++)
            prices[i] = (int)avg;

        Console.WriteLine("\nFinal Product Array:");
        for (int i = 0; i < prices.Length; i++)
            Console.WriteLine($"Index {i} → {prices[i]}");

        Console.WriteLine("\nTASK 2:");

        Console.Write("Enter number of branches: ");
        int branches = int.Parse(Console.ReadLine());

        Console.Write("Enter number of months: ");
        int months = int.Parse(Console.ReadLine());

        int[,] sales = new int[branches, months];

        for (int i = 0; i < branches; i++)
        {
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Branch {i + 1}, Month {j + 1} Sales: ");
                sales[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int highestSale = 0;

        for (int i = 0; i < branches; i++)
        {
            int total = 0;
            for (int j = 0; j < months; j++)
            {
                total += sales[i, j];
                if (sales[i, j] > highestSale)
                    highestSale = sales[i, j];
            }
            Console.WriteLine($"Total Sales of Branch {i + 1}: {total}");
        }

        Console.WriteLine("Highest Sale Overall: " + highestSale);


        Console.WriteLine("\nTASK 3:");

        int[][] jagged = new int[branches][];

        for (int i = 0; i < branches; i++)
        {
            int count = 0;

            for (int j = 0; j < months; j++)
                if (sales[i, j] >= avg)
                    count++;

            jagged[i] = new int[count];

            int index = 0;
            for (int j = 0; j < months; j++)
            {
                if (sales[i, j] >= avg)
                {
                    jagged[i][index] = sales[i, j];
                    index++;
                }
            }
        }

        Console.WriteLine("Jagged Array Output:");
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write("Branch " + (i + 1) + ": ");
            foreach (int val in jagged[i])
                Console.Write(val + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\nTASK 4:");

        Console.Write("Enter number of transactions: ");
        int t = int.Parse(Console.ReadLine());

        List<int> customerList = new List<int>();

        for (int i = 0; i < t; i++)
        {
            Console.Write("Enter Customer ID: ");
            customerList.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> uniqueSet = new HashSet<int>(customerList);
        List<int> cleanList = new List<int>(uniqueSet);

        Console.WriteLine("Cleaned Customer List:");
        foreach (int id in cleanList)
            Console.Write(id + " ");

        Console.WriteLine("\nDuplicates Removed: " +
            (customerList.Count - cleanList.Count));


        Console.WriteLine("\nTASK 5:");

        Console.Write("Enter number of transactions: ");
        int tr = int.Parse(Console.ReadLine());

        Dictionary<int, double> dict = new Dictionary<int, double>();

        for (int i = 0; i < tr; i++)
        {
            Console.Write("Enter Transaction ID: ");
            int id = int.Parse(Console.ReadLine());

            if (!dict.ContainsKey(id))
            {
                Console.Write("Enter Amount: ");
                double amt = double.Parse(Console.ReadLine());
                dict.Add(id, amt);
            }
            else
            {
                Console.WriteLine("Duplicate ID skipped!");
            }
        }

        SortedList<int, double> sorted = new SortedList<int, double>();

        foreach (var item in dict)
        {
            if (item.Value >= avg)
                sorted.Add(item.Key, item.Value);
        }

        Console.WriteLine("High Value Transactions:");
        foreach (var item in sorted)
            Console.WriteLine(item.Key + " → " + item.Value);

        Console.WriteLine("\nTASK 6:");

        Console.Write("Enter number of operations: ");
        int ops = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < ops; i++)
        {
            Console.Write("Enter operation: ");
            string op = Console.ReadLine();
            queue.Enqueue(op);
            stack.Push(op);
        }

        Console.WriteLine("Processing Queue:");
        while (queue.Count > 0)
            Console.WriteLine("Processed: " + queue.Dequeue());

        Console.WriteLine("Undo Operations:");
        for (int i = 0; i < 2 && stack.Count > 0; i++)
            Console.WriteLine("Undo: " + stack.Pop());

        Console.WriteLine("\nTASK 7:");

        Console.Write("Enter number of users: ");
        int users = int.Parse(Console.ReadLine());

        Hashtable table = new Hashtable();
        ArrayList list = new ArrayList();

        for (int i = 0; i < users; i++)
        {
            Console.Write("Enter username: ");
            string name = Console.ReadLine();

            Console.Write("Enter role: ");
            string role = Console.ReadLine();

            table[name] = role;
            list.Add(name);
            list.Add(role);
        }

        Console.WriteLine("\nHashtable Data:");
        foreach (DictionaryEntry d in table)
            Console.WriteLine(d.Key + " → " + d.Value);

        Console.WriteLine("\nArrayList (Mixed Data):");
        foreach (var item in list)
            Console.WriteLine(item);

        Console.WriteLine("\nRisk: ArrayList allows mixed data types causing runtime errors.");
    }
}
=======
using System;
using System.Collections;
using System.Collections.Generic;

class Program3
{
    public static void calculate()
    {
        Console.WriteLine("\n--- TASK 1: PRODUCT PRICE ANALYSIS ---");

        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int val;
            do
            {
                Console.Write($"Enter price of product {i + 1}: ");
                val = int.Parse(Console.ReadLine());
            } while (val <= 0);

            prices[i] = val;
            sum += val;
        }

        double avg = (double)sum / n;
        Console.WriteLine("Average Price = " + avg);

        Array.Sort(prices);

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < avg)
                prices[i] = 0;
        }

        int oldLength = prices.Length;
        Array.Resize(ref prices, oldLength + 5);

        for (int i = oldLength; i < prices.Length; i++)
            prices[i] = (int)avg;

        Console.WriteLine("\nFinal Product Array:");
        for (int i = 0; i < prices.Length; i++)
            Console.WriteLine($"Index {i} → {prices[i]}");

        Console.WriteLine("\n--- TASK 2: BRANCH SALES ---");

        Console.Write("Enter number of branches: ");
        int branches = int.Parse(Console.ReadLine());

        Console.Write("Enter number of months: ");
        int months = int.Parse(Console.ReadLine());

        int[,] sales = new int[branches, months];

        for (int i = 0; i < branches; i++)
        {
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Branch {i + 1}, Month {j + 1} Sales: ");
                sales[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int highestSale = 0;

        for (int i = 0; i < branches; i++)
        {
            int total = 0;
            for (int j = 0; j < months; j++)
            {
                total += sales[i, j];
                if (sales[i, j] > highestSale)
                    highestSale = sales[i, j];
            }
            Console.WriteLine($"Total Sales of Branch {i + 1}: {total}");
        }

        Console.WriteLine("Highest Sale Overall: " + highestSale);


        Console.WriteLine("\n--- TASK 3: JAGGED ARRAY ---");

        int[][] jagged = new int[branches][];

        for (int i = 0; i < branches; i++)
        {
            int count = 0;

            for (int j = 0; j < months; j++)
                if (sales[i, j] >= avg)
                    count++;

            jagged[i] = new int[count];

            int index = 0;
            for (int j = 0; j < months; j++)
            {
                if (sales[i, j] >= avg)
                {
                    jagged[i][index] = sales[i, j];
                    index++;
                }
            }
        }

        Console.WriteLine("Jagged Array Output:");
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write("Branch " + (i + 1) + ": ");
            foreach (int val in jagged[i])
                Console.Write(val + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\n--- TASK 4: CUSTOMER TRANSACTIONS ---");

        Console.Write("Enter number of transactions: ");
        int t = int.Parse(Console.ReadLine());

        List<int> customerList = new List<int>();

        for (int i = 0; i < t; i++)
        {
            Console.Write("Enter Customer ID: ");
            customerList.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> uniqueSet = new HashSet<int>(customerList);
        List<int> cleanList = new List<int>(uniqueSet);

        Console.WriteLine("Cleaned Customer List:");
        foreach (int id in cleanList)
            Console.Write(id + " ");

        Console.WriteLine("\nDuplicates Removed: " +
            (customerList.Count - cleanList.Count));


        Console.WriteLine("\n--- TASK 5: FINANCIAL TRANSACTIONS ---");

        Console.Write("Enter number of transactions: ");
        int tr = int.Parse(Console.ReadLine());

        Dictionary<int, double> dict = new Dictionary<int, double>();

        for (int i = 0; i < tr; i++)
        {
            Console.Write("Enter Transaction ID: ");
            int id = int.Parse(Console.ReadLine());

            if (!dict.ContainsKey(id))
            {
                Console.Write("Enter Amount: ");
                double amt = double.Parse(Console.ReadLine());
                dict.Add(id, amt);
            }
            else
            {
                Console.WriteLine("Duplicate ID skipped!");
            }
        }

        SortedList<int, double> sorted = new SortedList<int, double>();

        foreach (var item in dict)
        {
            if (item.Value >= avg)
                sorted.Add(item.Key, item.Value);
        }

        Console.WriteLine("High Value Transactions:");
        foreach (var item in sorted)
            Console.WriteLine(item.Key + " → " + item.Value);

        Console.WriteLine("\n--- TASK 6: PROCESS FLOW ---");

        Console.Write("Enter number of operations: ");
        int ops = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < ops; i++)
        {
            Console.Write("Enter operation: ");
            string op = Console.ReadLine();
            queue.Enqueue(op);
            stack.Push(op);
        }

        Console.WriteLine("Processing Queue:");
        while (queue.Count > 0)
            Console.WriteLine("Processed: " + queue.Dequeue());

        Console.WriteLine("Undo Operations:");
        for (int i = 0; i < 2 && stack.Count > 0; i++)
            Console.WriteLine("Undo: " + stack.Pop());

        Console.WriteLine("\n--- TASK 7: LEGACY DATA ---");

        Console.Write("Enter number of users: ");
        int users = int.Parse(Console.ReadLine());

        Hashtable table = new Hashtable();
        ArrayList list = new ArrayList();

        for (int i = 0; i < users; i++)
        {
            Console.Write("Enter username: ");
            string name = Console.ReadLine();

            Console.Write("Enter role: ");
            string role = Console.ReadLine();

            table[name] = role;
            list.Add(name);
            list.Add(role);
        }

        Console.WriteLine("\nHashtable Data:");
        foreach (DictionaryEntry d in table)
            Console.WriteLine(d.Key + " → " + d.Value);

        Console.WriteLine("\nArrayList (Mixed Data):");
        foreach (var item in list)
            Console.WriteLine(item);

        Console.WriteLine("\n⚠ Risk: ArrayList allows mixed data types causing runtime errors.");
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
using System.Collections;
using System.Collections.Generic;

class Program3
{
    public static void calculate()
    {
        Console.WriteLine("\n--- TASK 1: PRODUCT PRICE ANALYSIS ---");

        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int val;
            do
            {
                Console.Write($"Enter price of product {i + 1}: ");
                val = int.Parse(Console.ReadLine());
            } while (val <= 0);

            prices[i] = val;
            sum += val;
        }

        double avg = (double)sum / n;
        Console.WriteLine("Average Price = " + avg);

        Array.Sort(prices);

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < avg)
                prices[i] = 0;
        }

        int oldLength = prices.Length;
        Array.Resize(ref prices, oldLength + 5);

        for (int i = oldLength; i < prices.Length; i++)
            prices[i] = (int)avg;

        Console.WriteLine("\nFinal Product Array:");
        for (int i = 0; i < prices.Length; i++)
            Console.WriteLine($"Index {i} → {prices[i]}");

        Console.WriteLine("\n--- TASK 2: BRANCH SALES ---");

        Console.Write("Enter number of branches: ");
        int branches = int.Parse(Console.ReadLine());

        Console.Write("Enter number of months: ");
        int months = int.Parse(Console.ReadLine());

        int[,] sales = new int[branches, months];

        for (int i = 0; i < branches; i++)
        {
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Branch {i + 1}, Month {j + 1} Sales: ");
                sales[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int highestSale = 0;

        for (int i = 0; i < branches; i++)
        {
            int total = 0;
            for (int j = 0; j < months; j++)
            {
                total += sales[i, j];
                if (sales[i, j] > highestSale)
                    highestSale = sales[i, j];
            }
            Console.WriteLine($"Total Sales of Branch {i + 1}: {total}");
        }

        Console.WriteLine("Highest Sale Overall: " + highestSale);


        Console.WriteLine("\n--- TASK 3: JAGGED ARRAY ---");

        int[][] jagged = new int[branches][];

        for (int i = 0; i < branches; i++)
        {
            int count = 0;

            for (int j = 0; j < months; j++)
                if (sales[i, j] >= avg)
                    count++;

            jagged[i] = new int[count];

            int index = 0;
            for (int j = 0; j < months; j++)
            {
                if (sales[i, j] >= avg)
                {
                    jagged[i][index] = sales[i, j];
                    index++;
                }
            }
        }

        Console.WriteLine("Jagged Array Output:");
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write("Branch " + (i + 1) + ": ");
            foreach (int val in jagged[i])
                Console.Write(val + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\n--- TASK 4: CUSTOMER TRANSACTIONS ---");

        Console.Write("Enter number of transactions: ");
        int t = int.Parse(Console.ReadLine());

        List<int> customerList = new List<int>();

        for (int i = 0; i < t; i++)
        {
            Console.Write("Enter Customer ID: ");
            customerList.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> uniqueSet = new HashSet<int>(customerList);
        List<int> cleanList = new List<int>(uniqueSet);

        Console.WriteLine("Cleaned Customer List:");
        foreach (int id in cleanList)
            Console.Write(id + " ");

        Console.WriteLine("\nDuplicates Removed: " +
            (customerList.Count - cleanList.Count));


        Console.WriteLine("\n--- TASK 5: FINANCIAL TRANSACTIONS ---");

        Console.Write("Enter number of transactions: ");
        int tr = int.Parse(Console.ReadLine());

        Dictionary<int, double> dict = new Dictionary<int, double>();

        for (int i = 0; i < tr; i++)
        {
            Console.Write("Enter Transaction ID: ");
            int id = int.Parse(Console.ReadLine());

            if (!dict.ContainsKey(id))
            {
                Console.Write("Enter Amount: ");
                double amt = double.Parse(Console.ReadLine());
                dict.Add(id, amt);
            }
            else
            {
                Console.WriteLine("Duplicate ID skipped!");
            }
        }

        SortedList<int, double> sorted = new SortedList<int, double>();

        foreach (var item in dict)
        {
            if (item.Value >= avg)
                sorted.Add(item.Key, item.Value);
        }

        Console.WriteLine("High Value Transactions:");
        foreach (var item in sorted)
            Console.WriteLine(item.Key + " → " + item.Value);

        Console.WriteLine("\n--- TASK 6: PROCESS FLOW ---");

        Console.Write("Enter number of operations: ");
        int ops = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < ops; i++)
        {
            Console.Write("Enter operation: ");
            string op = Console.ReadLine();
            queue.Enqueue(op);
            stack.Push(op);
        }

        Console.WriteLine("Processing Queue:");
        while (queue.Count > 0)
            Console.WriteLine("Processed: " + queue.Dequeue());

        Console.WriteLine("Undo Operations:");
        for (int i = 0; i < 2 && stack.Count > 0; i++)
            Console.WriteLine("Undo: " + stack.Pop());

        Console.WriteLine("\n--- TASK 7: LEGACY DATA ---");

        Console.Write("Enter number of users: ");
        int users = int.Parse(Console.ReadLine());

        Hashtable table = new Hashtable();
        ArrayList list = new ArrayList();

        for (int i = 0; i < users; i++)
        {
            Console.Write("Enter username: ");
            string name = Console.ReadLine();

            Console.Write("Enter role: ");
            string role = Console.ReadLine();

            table[name] = role;
            list.Add(name);
            list.Add(role);
        }

        Console.WriteLine("\nHashtable Data:");
        foreach (DictionaryEntry d in table)
            Console.WriteLine(d.Key + " → " + d.Value);

        Console.WriteLine("\nArrayList (Mixed Data):");
        foreach (var item in list)
            Console.WriteLine(item);

        Console.WriteLine("\n⚠ Risk: ArrayList allows mixed data types causing runtime errors.");
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
