using System;

using BookStoreApplication;

    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Read initial input
            // Format: BookID Title Price Stock
            string[] input=Console.ReadLine().Split();
            string Id=input[0];
            string Title=input[1];
            int Price=int.Parse(input[2]);
            int Stock=int.Parse(input[3]);
            Book book = new Book(Id,Title,Price,Stock);

            BookUtility utility = new BookUtility(book);

            while (true)
            {
                // TODO:
                // Display menu:
                // 1 -> Display book details
                // 2 -> Update book price
                // 3 -> Update book stock
                // 4 -> Exit
                Console.WriteLine("1 → Display book details");
                Console.WriteLine("2 → Update book price");
                Console.WriteLine("3 → Update book stock");
                Console.WriteLine("4 → Exit");

                int choice = int.Parse(Console.ReadLine()); // TODO: Read user choice

                switch (choice)
                {
                    case 1:
                        utility.GetBookDetails();
                        break;

                    case 2:
                        // TODO:
                        // Read new price
                        // Call UpdateBookPrice()
                        int a=int.Parse(Console.ReadLine());
                        utility.UpdateBookPrice(a);

                        break;

                    case 3:
                        // TODO:
                        // Read new stock
                        // Call UpdateBookStock()
                        int b=int.Parse(Console.ReadLine());
                        utility.UpdateBookStock(b);
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        return;

                    default:
                        // TODO: Handle invalid choice
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }


