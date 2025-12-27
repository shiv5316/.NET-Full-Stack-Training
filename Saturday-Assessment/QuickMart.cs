<<<<<<< HEAD
<<<<<<< HEAD
using System;

class SaleTransaction
{
    public string InvoiceNo;
    public string CustomerName;
    public string ItemName;
    public int Quantity;
    public decimal PurchaseAmount;
    public decimal SellingAmount;

    public string ProfitOrLossStatus;
    public decimal ProfitOrLossAmount;
    public decimal ProfitMarginPercent;
}

class Program2
{
    static SaleTransaction LastTransaction;
    static bool HasLastTransaction = false;
    public static void calculate()
    {
        while (true)
        {
            Console.WriteLine("1. Create New Transaction");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateTransaction();
                    break;

                case "2":
                    ViewTransaction();
                    break;

                case "3":
                    CalculateProfitLoss();
                    break;

                case "4":
                    Console.WriteLine("Thank you. Application closed normally.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateTransaction()
    {
        SaleTransaction t = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        t.InvoiceNo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(t.InvoiceNo))
        {
            Console.WriteLine("Invoice number cannot be empty.");
            return;
        }

        Console.Write("Enter Customer Name: ");
        t.CustomerName = Console.ReadLine();
        if (!t.CustomerName.All(char.IsLetter))
        {
            Console.WriteLine("Customer name Invalid");
            return;
        }

        Console.Write("Enter Item Name: ");
        t.ItemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out t.Quantity) || t.Quantity <= 0)
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        Console.Write("Enter Purchase Amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out t.PurchaseAmount) || t.PurchaseAmount <= 0)
        {
            Console.WriteLine("Invalid purchase amount.");
            return;
        }

        Console.Write("Enter Selling Amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out t.SellingAmount) || t.SellingAmount < 0)
        {
            Console.WriteLine("Invalid selling amount.");
            return;
        }

        Calculate(t);

        LastTransaction = t;
        HasLastTransaction = true;

        Console.WriteLine("\nTransaction saved successfully.");
        PrintResult(t);
    }

    static void ViewTransaction()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create one first.");
            return;
        }

        Console.WriteLine("\nLast Transaction");
        Console.WriteLine("Invoice No       : " + LastTransaction.InvoiceNo);
        Console.WriteLine("Customer Name    : " + LastTransaction.CustomerName);
        Console.WriteLine("Item Name        : " + LastTransaction.ItemName);
        Console.WriteLine("Quantity         : " + LastTransaction.Quantity);
        Console.WriteLine("Purchase Amount  : " + LastTransaction.PurchaseAmount);
        Console.WriteLine("Selling Amount   : " + LastTransaction.SellingAmount);
        Console.WriteLine("Status           : " + LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amt  : " + LastTransaction.ProfitOrLossAmount);
        Console.WriteLine("Profit %         : " + LastTransaction.ProfitMarginPercent);
    }

    static void CalculateProfitLoss()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create one first.");
            return;
        }

        Calculate(LastTransaction);
        PrintResult(LastTransaction);
    }
    static void Calculate(SaleTransaction t)
    {
        if (t.SellingAmount > t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "PROFIT";
            t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount;
        }
        else if (t.SellingAmount < t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "LOSS";
            t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
        }
        else
        {
            t.ProfitOrLossStatus = "BREAK-EVEN";
            t.ProfitOrLossAmount = 0;
        }

        t.ProfitMarginPercent =
            (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
    }
    static void PrintResult(SaleTransaction t)
    {
        Console.WriteLine("Status             : " + t.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount : " + t.ProfitOrLossAmount.ToString("0.00"));
        Console.WriteLine("Profit Margin (%)  : " + t.ProfitMarginPercent.ToString("0.00"));
    }
}
=======
using System;

class SaleTransaction
{
    public string InvoiceNo;
    public string CustomerName;
    public string ItemName;
    public int Quantity;
    public decimal PurchaseAmount;
    public decimal SellingAmount;

    public string ProfitOrLossStatus;
    public decimal ProfitOrLossAmount;
    public decimal ProfitMarginPercent;
}

class Program
{
    static SaleTransaction LastTransaction;
    static bool HasLastTransaction = false;
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Create New Transaction");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateTransaction();
                    break;

                case "2":
                    ViewTransaction();
                    break;

                case "3":
                    CalculateProfitLoss();
                    break;

                case "4":
                    Console.WriteLine("Thank you. Application closed normally.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateTransaction()
    {
        SaleTransaction t = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        t.InvoiceNo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(t.InvoiceNo))
        {
            Console.WriteLine("Invoice number cannot be empty.");
            return;
        }

        Console.Write("Enter Customer Name: ");
        t.CustomerName = Console.ReadLine();
        if (!t.CustomerName.All(char.IsLetter))
        {
            Console.WriteLine("Customer name Invalid");
            return;
        }

        Console.Write("Enter Item Name: ");
        t.ItemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out t.Quantity) || t.Quantity <= 0)
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        Console.Write("Enter Purchase Amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out t.PurchaseAmount) || t.PurchaseAmount <= 0)
        {
            Console.WriteLine("Invalid purchase amount.");
            return;
        }

        Console.Write("Enter Selling Amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out t.SellingAmount) || t.SellingAmount < 0)
        {
            Console.WriteLine("Invalid selling amount.");
            return;
        }

        Calculate(t);

        LastTransaction = t;
        HasLastTransaction = true;

        Console.WriteLine("\nTransaction saved successfully.");
        PrintResult(t);
    }

    static void ViewTransaction()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create one first.");
            return;
        }

        Console.WriteLine("\nLast Transaction");
        Console.WriteLine("Invoice No       : " + LastTransaction.InvoiceNo);
        Console.WriteLine("Customer Name    : " + LastTransaction.CustomerName);
        Console.WriteLine("Item Name        : " + LastTransaction.ItemName);
        Console.WriteLine("Quantity         : " + LastTransaction.Quantity);
        Console.WriteLine("Purchase Amount  : " + LastTransaction.PurchaseAmount);
        Console.WriteLine("Selling Amount   : " + LastTransaction.SellingAmount);
        Console.WriteLine("Status           : " + LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amt  : " + LastTransaction.ProfitOrLossAmount);
        Console.WriteLine("Profit %         : " + LastTransaction.ProfitMarginPercent);
    }

    static void CalculateProfitLoss()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create one first.");
            return;
        }

        Calculate(LastTransaction);
        PrintResult(LastTransaction);
    }
    static void Calculate(SaleTransaction t)
    {
        if (t.SellingAmount > t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "PROFIT";
            t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount;
        }
        else if (t.SellingAmount < t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "LOSS";
            t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
        }
        else
        {
            t.ProfitOrLossStatus = "BREAK-EVEN";
            t.ProfitOrLossAmount = 0;
        }

        t.ProfitMarginPercent =
            (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
    }
    static void PrintResult(SaleTransaction t)
    {
        Console.WriteLine("Status             : " + t.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount : " + t.ProfitOrLossAmount.ToString("0.00"));
        Console.WriteLine("Profit Margin (%)  : " + t.ProfitMarginPercent.ToString("0.00"));
    }
}

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;

class SaleTransaction
{
    public string InvoiceNo;
    public string CustomerName;
    public string ItemName;
    public int Quantity;
    public decimal PurchaseAmount;
    public decimal SellingAmount;

    public string ProfitOrLossStatus;
    public decimal ProfitOrLossAmount;
    public decimal ProfitMarginPercent;
}

class Program
{
    static SaleTransaction LastTransaction;
    static bool HasLastTransaction = false;
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Create New Transaction");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateTransaction();
                    break;

                case "2":
                    ViewTransaction();
                    break;

                case "3":
                    CalculateProfitLoss();
                    break;

                case "4":
                    Console.WriteLine("Thank you. Application closed normally.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateTransaction()
    {
        SaleTransaction t = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        t.InvoiceNo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(t.InvoiceNo))
        {
            Console.WriteLine("Invoice number cannot be empty.");
            return;
        }

        Console.Write("Enter Customer Name: ");
        t.CustomerName = Console.ReadLine();
        if (!t.CustomerName.All(char.IsLetter))
        {
            Console.WriteLine("Customer name Invalid");
            return;
        }

        Console.Write("Enter Item Name: ");
        t.ItemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out t.Quantity) || t.Quantity <= 0)
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        Console.Write("Enter Purchase Amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out t.PurchaseAmount) || t.PurchaseAmount <= 0)
        {
            Console.WriteLine("Invalid purchase amount.");
            return;
        }

        Console.Write("Enter Selling Amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out t.SellingAmount) || t.SellingAmount < 0)
        {
            Console.WriteLine("Invalid selling amount.");
            return;
        }

        Calculate(t);

        LastTransaction = t;
        HasLastTransaction = true;

        Console.WriteLine("\nTransaction saved successfully.");
        PrintResult(t);
    }

    static void ViewTransaction()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create one first.");
            return;
        }

        Console.WriteLine("\nLast Transaction");
        Console.WriteLine("Invoice No       : " + LastTransaction.InvoiceNo);
        Console.WriteLine("Customer Name    : " + LastTransaction.CustomerName);
        Console.WriteLine("Item Name        : " + LastTransaction.ItemName);
        Console.WriteLine("Quantity         : " + LastTransaction.Quantity);
        Console.WriteLine("Purchase Amount  : " + LastTransaction.PurchaseAmount);
        Console.WriteLine("Selling Amount   : " + LastTransaction.SellingAmount);
        Console.WriteLine("Status           : " + LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amt  : " + LastTransaction.ProfitOrLossAmount);
        Console.WriteLine("Profit %         : " + LastTransaction.ProfitMarginPercent);
    }

    static void CalculateProfitLoss()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create one first.");
            return;
        }

        Calculate(LastTransaction);
        PrintResult(LastTransaction);
    }
    static void Calculate(SaleTransaction t)
    {
        if (t.SellingAmount > t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "PROFIT";
            t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount;
        }
        else if (t.SellingAmount < t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "LOSS";
            t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
        }
        else
        {
            t.ProfitOrLossStatus = "BREAK-EVEN";
            t.ProfitOrLossAmount = 0;
        }

        t.ProfitMarginPercent =
            (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
    }
    static void PrintResult(SaleTransaction t)
    {
        Console.WriteLine("Status             : " + t.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount : " + t.ProfitOrLossAmount.ToString("0.00"));
        Console.WriteLine("Profit Margin (%)  : " + t.ProfitMarginPercent.ToString("0.00"));
    }
}

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
