using System;
class Program5
{
    public static void calculate()
    {
        Console.WriteLine("Enter number of products: ");
        int n=int.Parse(Console.ReadLine());
        int[] prices=new int[n];
        int sum=0;
        for(int i = 0; i < n; i++)
        {
            int p;
            while (true)
            {
                Console.Write($"Enter positive price for product {i}: ");
                p = int.Parse(Console.ReadLine());
                if (p > 0) break;
                Console.WriteLine("Price must be positive.");
            }
            prices[i]=p;
            sum+=p;
        }
        double avg=(double)sum/n;
        Console.WriteLine("Average price= "+avg);
        Array.Sort(prices);
        for(int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < avg)
                prices[i] = 0;
        }
        int oldLen=prices.Length;
        Array.Resize(ref prices,prices.Length+5);
        int avgInt = (int)Math.Round(avg);
        for (int i = oldLen; i < prices.Length; i++)
        {
            prices[i] = avgInt;
        }
        Console.WriteLine("\nFinal array:");
        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine($"Index {i}: {prices[i]}");
        }

        Console.ReadLine();
    }
}
    