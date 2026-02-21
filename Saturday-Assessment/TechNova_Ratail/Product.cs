using System;
using System.Collections.Generic;
namespace TechNovaInventory
{
    public abstract class Product
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public decimal Price{get; set;}
        public Product(int id,string name,decimal price)
        {
            Id=id;
            Name=name;
            Price=price;
        }
        public abstract void Display();

    }
    public class Electronics : Product
    {
        public string Brand{get; set;}
        public string Model{get; set;}
        public int WarrantyPeriod{get; set;}
        public int PowerUsage{get; set;}
        public DateTime ManufacturingDate{get; set;}
        public Electronics(int id,string name,decimal price,string brand,string model,int warranty,int power,DateTime mfg) : base(id, name, price)
        {
            Brand=brand;
            Model=model;
            WarrantyPeriod=warranty;
            PowerUsage=power;
            ManufacturingDate=mfg;
        }
        public override void Display()
        {
            Console.WriteLine($"Electronics: {Name}, Brand: {Brand}, Model: {Model}, Warranty: {WarrantyPeriod} months");
        }
    }

    public class Grocery : Product
    {
        public DateTime ExpiryDate{get;set;}
        public double Weight{get;set;}
        public bool IsOrganic{get;set;}
        public double StorageTemperature{get;set;}

        public Grocery(int id,string name,decimal price,DateTime expiry,double weight,bool organic,double temp) : base(id, name, price)
        {
            ExpiryDate=expiry;
            Weight=weight;
            IsOrganic=organic;
            StorageTemperature=temp;
        }
        public override void Display()
        {
            Console.WriteLine($"Grocery: {Name}, Expiry: {ExpiryDate.ToShortDateString()}, Weight: {Weight}kg");
        }
    }

    public class Clothing : Product
    {
        public string Size{get;set;}
        public string FabricType{get;set;}
        public string Gender{get;set;}
        public string Color{get;set;}

        public Clothing(int id,string name,decimal price,string size,string type,string gender,string color) : base(id, name, price)
        {
            Size=size;
            FabricType=type;
            Gender=gender;
            Color=color;
        }
        public override void Display()
        {
            Console.WriteLine($"Clothing: {Name}, Size: {Size}, Color: {Color}, Fabric: {FabricType}");
        }

    }
}

