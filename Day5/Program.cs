<<<<<<< HEAD
<<<<<<< HEAD
﻿
using System;
using System.Collections.Generic;
using lib = LibrarySystem.Items;  
using LibrarySystem;
class Program
{
    static void Main()
    {
        lib.Book book = new lib.Book
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemID = 101
        };

        lib.Magazine magazine = new lib.Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemID = 201
        };
        List<lib.LibraryItem> items = new List<lib.LibraryItem>();
        items.Add(book);
        items.Add(magazine);

        foreach (lib.LibraryItem item in items)
        {
            item.Display();
            Console.WriteLine("Fees for 3 days: " + item.CalculateLateFee(3));
        }

        Console.WriteLine(
            "Method selection happens at runtime based on object type."
        );
        lib.IReservable reservable = book;
        reservable.ReserveItem();

        lib.INotifiable notifiable = book;
        notifiable.NotifyAvailability("Please return the book on time.");
        LibrarySystem.LibraryAnalytics.TotalBorrowedItems += 5;

        LibrarySystem.LibraryAnalytics.DisplayAnalytics();
        LibrarySystem.UserRole userRole = LibrarySystem.UserRole.Member;
        LibrarySystem.ItemStatus itemStatus = LibrarySystem.ItemStatus.Borrowed;

        Console.WriteLine("User Role: " + userRole);
        Console.WriteLine("Item Status: " + itemStatus);

    }
}
=======
﻿
using System;
using System.Collections.Generic;
using lib = LibrarySystem.Items;  
using LibrarySystem;
class Program
{
    static void Main()
    {
        lib.Book book = new lib.Book
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemID = 101
        };

        lib.Magazine magazine = new lib.Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemID = 201
        };
        List<lib.LibraryItem> items = new List<lib.LibraryItem>();
        items.Add(book);
        items.Add(magazine);

        foreach (lib.LibraryItem item in items)
        {
            item.Display();
            Console.WriteLine("Fees for 3 days: " + item.CalculateLateFee(3));
        }

        Console.WriteLine(
            "Method selection happens at runtime based on object type."
        );
        lib.IReservable reservable = book;
        reservable.ReserveItem();

        lib.INotifiable notifiable = book;
        notifiable.NotifyAvailability("Please return the book on time.");
        LibrarySystem.LibraryAnalytics.TotalBorrowedItems += 5;

        LibrarySystem.LibraryAnalytics.DisplayAnalytics();
        LibrarySystem.UserRole userRole = LibrarySystem.UserRole.Member;
        LibrarySystem.ItemStatus itemStatus = LibrarySystem.ItemStatus.Borrowed;

        Console.WriteLine("User Role: " + userRole);
        Console.WriteLine("Item Status: " + itemStatus);

    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
﻿
using System;
using System.Collections.Generic;
using lib = LibrarySystem.Items;  
using LibrarySystem;
class Program
{
    static void Main()
    {
        lib.Book book = new lib.Book
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemID = 101
        };

        lib.Magazine magazine = new lib.Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemID = 201
        };
        List<lib.LibraryItem> items = new List<lib.LibraryItem>();
        items.Add(book);
        items.Add(magazine);

        foreach (lib.LibraryItem item in items)
        {
            item.Display();
            Console.WriteLine("Fees for 3 days: " + item.CalculateLateFee(3));
        }

        Console.WriteLine(
            "Method selection happens at runtime based on object type."
        );
        lib.IReservable reservable = book;
        reservable.ReserveItem();

        lib.INotifiable notifiable = book;
        notifiable.NotifyAvailability("Please return the book on time.");
        LibrarySystem.LibraryAnalytics.TotalBorrowedItems += 5;

        LibrarySystem.LibraryAnalytics.DisplayAnalytics();
        LibrarySystem.UserRole userRole = LibrarySystem.UserRole.Member;
        LibrarySystem.ItemStatus itemStatus = LibrarySystem.ItemStatus.Borrowed;

        Console.WriteLine("User Role: " + userRole);
        Console.WriteLine("Item Status: " + itemStatus);

    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
