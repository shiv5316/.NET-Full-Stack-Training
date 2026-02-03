using System;
using System.Collections.Generic;

public class Bike
{
    public string Model { get; set; }
    public int PricePerDay { get; set; }
    public string Brand { get; set; }
    public Bike(string model, string brand, int pricePerDay)
    {
        Model = model;
        Brand = brand;
        PricePerDay = pricePerDay;
    }
}

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;

        Bike bike = new Bike(model, brand, pricePerDay);

        Program.bikeDetails.Add(key, bike);

        Console.WriteLine("\nBike details added successfully\n");
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> grouped =
            new SortedDictionary<string, List<Bike>>();

        foreach (var bike in Program.bikeDetails.Values)
        {
            if (!grouped.ContainsKey(bike.Brand))
            {
                grouped[bike.Brand] = new List<Bike>();
            }

            grouped[bike.Brand].Add(bike);
        }

        return grouped;
    }
}

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails =
        new SortedDictionary<int, Bike>();

    static void Main()
    {
        BikeUtility utility = new BikeUtility();

        while (true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit\n");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("\nEnter the model: ");
                string model = Console.ReadLine();

                Console.Write("Enter the brand: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the price per day: ");
                int price = int.Parse(Console.ReadLine());

                utility.AddBikeDetails(model, brand, price);
            }

            else if (choice == 2)
            {
                var groupedBikes = utility.GroupBikesByBrand();

                Console.WriteLine();

                foreach (var brandGroup in groupedBikes)
                {
                    foreach (var bike in brandGroup.Value)
                    {
                        Console.WriteLine($"{bike.Brand} {bike.Model}");
                    }
                }

                Console.WriteLine();
            }

            else if (choice == 3)
            {
                break;
            }

            else
            {
                Console.WriteLine("\nInvalid choice. Try again.\n");
            }
        }
    }
}
