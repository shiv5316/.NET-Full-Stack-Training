namespace TechNovaInventory
{
    public class Laptop : Electronics
    {
        public int RAM{get;set;}
        public int Storage{get;set;}
        public Laptop(int id, string name, decimal price,string brand, string model, int warranty, int power,DateTime mfg, int ram, int storage)
        : base(id, name, price, brand, model, warranty, power, mfg)
        {
            RAM=ram;
            Storage=storage;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Ram: {RAM}GB,Storage: {Storage}GB");
        }
    }

    
    public class Inventory<T> where T : Product
    {
        private List<T> products = new List<T>();

        public void AddProduct(T product)
        {
            products.Add(product);
        }

        public void ShowAll()
        {
            foreach (var p in products)
            {
                p.Display();
            }
        }
    }
}

