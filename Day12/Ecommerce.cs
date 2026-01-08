<<<<<<< HEAD

using System;
using System.Collections.Generic;

namespace EcommerceAssessment{
    class Repository<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public List<T> GetAll()
        {
            return items;
        }
    }
    class Order
    {
        public int OrderId{ get; set; }
        public string? CustomerName{ get; set; }
        public double Amount{ get; set; }
        public override string ToString()
        {
            return $"Order Id: {OrderId}, Name of custome: {CustomerName}, Amount: {Amount}";
        }
    }
    public delegate void OrderCallback(string message);
    class OrderProcessor
    {
        public event Action<string>? OrderProcessed;

        public void ProcessOrder(
            Order order,
            Func<double, double> taxCalculator,
            Func<double, double> discountCalculator,
            Predicate<Order> validator,
            OrderCallback callback)
        {
            if(!validator(order))
            {
                callback("Order validation failed");
                return;
            }         
            double tax = taxCalculator(order.Amount);
            double discount = discountCalculator(order.Amount);
            order.Amount = order.Amount + tax - discount;
            callback($"Order {order.OrderId} processed successfully");
            OrderProcessed?.Invoke($"Event on Order {order.OrderId} completed");
        }
    }
}
=======

using System;
using System.Collections.Generic;

namespace EcommerceAssessment{
    class Repository<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public List<T> GetAll()
        {
            return items;
        }
    }
    class Order
    {
        public int OrderId{ get; set; }
        public string? CustomerName{ get; set; }
        public double Amount{ get; set; }
        public override string ToString()
        {
            return $"Order Id: {OrderId}, Name of custome: {CustomerName}, Amount: {Amount}";
        }
    }
    public delegate void OrderCallback(string message);
    class OrderProcessor
    {
        public event Action<string>? OrderProcessed;

        public void ProcessOrder(
            Order order,
            Func<double, double> taxCalculator,
            Func<double, double> discountCalculator,
            Predicate<Order> validator,
            OrderCallback callback)
        {
            if(!validator(order))
            {
                callback("Order validation failed");
                return;
            }         
            double tax = taxCalculator(order.Amount);
            double discount = discountCalculator(order.Amount);
            order.Amount = order.Amount + tax - discount;
            callback($"Order {order.OrderId} processed successfully");
            OrderProcessed?.Invoke($"Event on Order {order.OrderId} completed");
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
