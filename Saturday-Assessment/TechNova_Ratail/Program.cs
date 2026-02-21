
using System;
using TechNovaInventory;

class Program
{
    static void Main()
    {
        Inventory<Electronics> electronicsInventory = new Inventory<Electronics>();

        Laptop laptop = new Laptop(1, "Gaming Laptop", 80000,"HP", "Victus", 24, 150,DateTime.Now.AddMonths(-2), 16, 512);
        electronicsInventory.AddProduct(laptop);
        Inventory<Grocery> groceryInventory = new Inventory<Grocery>();
        Grocery rice = new Grocery(2, "Basmati Rice", 1200,DateTime.Now.AddMonths(6), 5, true, 20);
        groceryInventory.AddProduct(rice);
        Inventory<Clothing> clothingInventory = new Inventory<Clothing>();
        Clothing shirt = new Clothing(3, "Formal Shirt", 1500,"M", "Cotton", "Men", "Blue");

        clothingInventory.AddProduct(shirt);
        Console.WriteLine("Electronics");
        electronicsInventory.ShowAll();

        Console.WriteLine("\nGrocery");
        groceryInventory.ShowAll();

        Console.WriteLine("\nClothing");
        clothingInventory.ShowAll();
    }
}
