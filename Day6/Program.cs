<<<<<<< HEAD
<<<<<<< HEAD
﻿// using System;
// using System.Runtime.CompilerServices;
// class Program
// {
//     static void Main()
//     {
//         StockPrice sp=new StockPrice
//         {
//             StockSymbol="AAPL",
//             Quantity=1222
//         };
//     }
//     sp.display();
//     StockPrice cp=sp;
//     cp.Quantity=1200;
//     cp.display();

// }

using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
       PriceSnapshot snapshot = new PriceSnapshot
        {
            Symbol = "AAPL",
            Price = 150.50m
        };

        Console.WriteLine($"Stock Symbol: {snapshot.Symbol}");
        Console.WriteLine($"Stock Price: {snapshot.Price}");
        Console.WriteLine();

        // Repository
        TradeRepository<EquityTrade> repository =
            new TradeRepository<EquityTrade>();

        // Trade 1
        EquityTrade trade1 = new EquityTrade
        {
            TradeId = 1,
            Symbol = "AAPL",
            Quantity = 100,
            MarketPrice = 150.50m
        };

        // Trade 2
        EquityTrade trade2 = new EquityTrade
        {
            TradeId = 2,
            Symbol = "MSFT",
            Quantity = 50,
            MarketPrice = null
        };

        repository.AddTrade(trade1);
        repository.AddTrade(trade2);

        Console.WriteLine();

        foreach (var trade in repository.GetTrades())
        {
            TradeProcessor.ProcessTrade(trade);

            decimal value = trade.CalculateTradeValue();
            decimal brokerage = value.CalculateBrokerage();
            decimal gst = brokerage.CalculateGST();

            Console.WriteLine($"Trade Value: {value}");
            Console.WriteLine($"Brokerage: {brokerage}");
            Console.WriteLine($"GST: {gst}");
            Console.WriteLine(trade);
            Console.WriteLine();
        }

        // Boxing and Unboxing
        object boxed = TradeAnalytics.TotalTrades;
        int unboxed = (int)boxed;

        Console.WriteLine($"Boxed Trade Count: {boxed}");
        Console.WriteLine($"Unboxed Trade Count: {unboxed}");

        TradeAnalytics.DisplayAnalytics();
    }
}

=======
﻿// using System;
// using System.Runtime.CompilerServices;
// class Program
// {
//     static void Main()
//     {
//         StockPrice sp=new StockPrice
//         {
//             StockSymbol="AAPL",
//             Quantity=1222
//         };
//     }
//     sp.display();
//     StockPrice cp=sp;
//     cp.Quantity=1200;
//     cp.display();

// }

using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
       PriceSnapshot snapshot = new PriceSnapshot
        {
            Symbol = "AAPL",
            Price = 150.50m
        };

        Console.WriteLine($"Stock Symbol: {snapshot.Symbol}");
        Console.WriteLine($"Stock Price: {snapshot.Price}");
        Console.WriteLine();

        // Repository
        TradeRepository<EquityTrade> repository =
            new TradeRepository<EquityTrade>();

        // Trade 1
        EquityTrade trade1 = new EquityTrade
        {
            TradeId = 1,
            Symbol = "AAPL",
            Quantity = 100,
            MarketPrice = 150.50m
        };

        // Trade 2
        EquityTrade trade2 = new EquityTrade
        {
            TradeId = 2,
            Symbol = "MSFT",
            Quantity = 50,
            MarketPrice = null
        };

        repository.AddTrade(trade1);
        repository.AddTrade(trade2);

        Console.WriteLine();

        foreach (var trade in repository.GetTrades())
        {
            TradeProcessor.ProcessTrade(trade);

            decimal value = trade.CalculateTradeValue();
            decimal brokerage = value.CalculateBrokerage();
            decimal gst = brokerage.CalculateGST();

            Console.WriteLine($"Trade Value: {value}");
            Console.WriteLine($"Brokerage: {brokerage}");
            Console.WriteLine($"GST: {gst}");
            Console.WriteLine(trade);
            Console.WriteLine();
        }

        // Boxing and Unboxing
        object boxed = TradeAnalytics.TotalTrades;
        int unboxed = (int)boxed;

        Console.WriteLine($"Boxed Trade Count: {boxed}");
        Console.WriteLine($"Unboxed Trade Count: {unboxed}");

        TradeAnalytics.DisplayAnalytics();
    }
}

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
﻿// using System;
// using System.Runtime.CompilerServices;
// class Program
// {
//     static void Main()
//     {
//         StockPrice sp=new StockPrice
//         {
//             StockSymbol="AAPL",
//             Quantity=1222
//         };
//     }
//     sp.display();
//     StockPrice cp=sp;
//     cp.Quantity=1200;
//     cp.display();

// }

using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
       PriceSnapshot snapshot = new PriceSnapshot
        {
            Symbol = "AAPL",
            Price = 150.50m
        };

        Console.WriteLine($"Stock Symbol: {snapshot.Symbol}");
        Console.WriteLine($"Stock Price: {snapshot.Price}");
        Console.WriteLine();

        // Repository
        TradeRepository<EquityTrade> repository =
            new TradeRepository<EquityTrade>();

        // Trade 1
        EquityTrade trade1 = new EquityTrade
        {
            TradeId = 1,
            Symbol = "AAPL",
            Quantity = 100,
            MarketPrice = 150.50m
        };

        // Trade 2
        EquityTrade trade2 = new EquityTrade
        {
            TradeId = 2,
            Symbol = "MSFT",
            Quantity = 50,
            MarketPrice = null
        };

        repository.AddTrade(trade1);
        repository.AddTrade(trade2);

        Console.WriteLine();

        foreach (var trade in repository.GetTrades())
        {
            TradeProcessor.ProcessTrade(trade);

            decimal value = trade.CalculateTradeValue();
            decimal brokerage = value.CalculateBrokerage();
            decimal gst = brokerage.CalculateGST();

            Console.WriteLine($"Trade Value: {value}");
            Console.WriteLine($"Brokerage: {brokerage}");
            Console.WriteLine($"GST: {gst}");
            Console.WriteLine(trade);
            Console.WriteLine();
        }

        // Boxing and Unboxing
        object boxed = TradeAnalytics.TotalTrades;
        int unboxed = (int)boxed;

        Console.WriteLine($"Boxed Trade Count: {boxed}");
        Console.WriteLine($"Unboxed Trade Count: {unboxed}");

        TradeAnalytics.DisplayAnalytics();
    }
}

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
    