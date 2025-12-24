<<<<<<< HEAD
<<<<<<< HEAD
using System;
using System.Collections.Generic;
public struct PriceSnapshot
{
    public string Symbol;
    public decimal Price;
}

public abstract class Trade
{
    public int TradeId { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public int Quantity { get; set; }

    public abstract decimal CalculateTradeValue();

    public override string ToString()
    {
        return $"TradeId: {TradeId}, Symbol: {Symbol}, Qty: {Quantity}";
    }
}
public class EquityTrade : Trade
{
    public decimal? MarketPrice { get; set; }

    public override decimal CalculateTradeValue()
    {
        return (MarketPrice ?? 0) * Quantity;
    }
}
public static class TradeAnalytics
{
    public static int TotalTrades = 0;

    public static void DisplayAnalytics()
    {
        Console.WriteLine($"Total Trades Executed: {TotalTrades}");
    }
}
public class TradeRepository<T> where T : Trade
{
    private List<T> trades = new List<T>();

    public void AddTrade(T trade)
    {
        trades.Add(trade);
        TradeAnalytics.TotalTrades++;
        Console.WriteLine("Trade added successfully");
    }

    public IEnumerable<T> GetTrades()
    {
        return trades;
    }
}
public static class FinancialExtensions
{
    public static decimal CalculateBrokerage(this decimal value)
    {
        return value * 0.001m;
    }

    public static decimal CalculateGST(this decimal value)
    {
        return value * 0.18m;
    }
}
public static class TradeProcessor
{
    public static void ProcessTrade(Trade trade)
    {
        if (trade is EquityTrade)
        {
            Console.WriteLine("Processing Equity Trade");
        }
    }
}
=======
using System;
using System.Collections.Generic;
public struct PriceSnapshot
{
    public string Symbol;
    public decimal Price;
}

public abstract class Trade
{
    public int TradeId { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public int Quantity { get; set; }

    public abstract decimal CalculateTradeValue();

    public override string ToString()
    {
        return $"TradeId: {TradeId}, Symbol: {Symbol}, Qty: {Quantity}";
    }
}
public class EquityTrade : Trade
{
    public decimal? MarketPrice { get; set; }

    public override decimal CalculateTradeValue()
    {
        return (MarketPrice ?? 0) * Quantity;
    }
}
public static class TradeAnalytics
{
    public static int TotalTrades = 0;

    public static void DisplayAnalytics()
    {
        Console.WriteLine($"Total Trades Executed: {TotalTrades}");
    }
}
public class TradeRepository<T> where T : Trade
{
    private List<T> trades = new List<T>();

    public void AddTrade(T trade)
    {
        trades.Add(trade);
        TradeAnalytics.TotalTrades++;
        Console.WriteLine("Trade added successfully");
    }

    public IEnumerable<T> GetTrades()
    {
        return trades;
    }
}
public static class FinancialExtensions
{
    public static decimal CalculateBrokerage(this decimal value)
    {
        return value * 0.001m;
    }

    public static decimal CalculateGST(this decimal value)
    {
        return value * 0.18m;
    }
}
public static class TradeProcessor
{
    public static void ProcessTrade(Trade trade)
    {
        if (trade is EquityTrade)
        {
            Console.WriteLine("Processing Equity Trade");
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
using System.Collections.Generic;
public struct PriceSnapshot
{
    public string Symbol;
    public decimal Price;
}

public abstract class Trade
{
    public int TradeId { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public int Quantity { get; set; }

    public abstract decimal CalculateTradeValue();

    public override string ToString()
    {
        return $"TradeId: {TradeId}, Symbol: {Symbol}, Qty: {Quantity}";
    }
}
public class EquityTrade : Trade
{
    public decimal? MarketPrice { get; set; }

    public override decimal CalculateTradeValue()
    {
        return (MarketPrice ?? 0) * Quantity;
    }
}
public static class TradeAnalytics
{
    public static int TotalTrades = 0;

    public static void DisplayAnalytics()
    {
        Console.WriteLine($"Total Trades Executed: {TotalTrades}");
    }
}
public class TradeRepository<T> where T : Trade
{
    private List<T> trades = new List<T>();

    public void AddTrade(T trade)
    {
        trades.Add(trade);
        TradeAnalytics.TotalTrades++;
        Console.WriteLine("Trade added successfully");
    }

    public IEnumerable<T> GetTrades()
    {
        return trades;
    }
}
public static class FinancialExtensions
{
    public static decimal CalculateBrokerage(this decimal value)
    {
        return value * 0.001m;
    }

    public static decimal CalculateGST(this decimal value)
    {
        return value * 0.18m;
    }
}
public static class TradeProcessor
{
    public static void ProcessTrade(Trade trade)
    {
        if (trade is EquityTrade)
        {
            Console.WriteLine("Processing Equity Trade");
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
