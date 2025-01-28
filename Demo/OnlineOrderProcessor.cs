using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class OnlineOrderProcessor :Order, IOrderProcessor
    {
        public OnlineOrderProcessor(int id, string name, decimal amount)
        {
            this.OrderId = id;
            this.CustomerName = name;
            this.OrderAmount = amount;
        }
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * .10M;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Order Processed Online Successfully!");
        }

        public override string ToString()
        {
            return$"Order {OrderId} processed for {CustomerName}. Final amount after 10% discount: {OrderAmount - CalculateDiscount(OrderAmount):c}";

        }
    }
}
