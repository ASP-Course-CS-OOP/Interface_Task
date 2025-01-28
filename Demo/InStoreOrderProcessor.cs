using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    internal class InStoreOrderProcessor : Order, IOrderProcessor
    {

        public InStoreOrderProcessor(int id, string name, decimal amount)
        {
            this.OrderId = id;
            this.CustomerName = name;
            this.OrderAmount = amount;
        }
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * .05M;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Order Processed In-Store Successfully!");
        }

        public override string ToString()
        {
            return $"Order {OrderId} processed for {CustomerName}. Final amount after 10% discount: {OrderAmount - CalculateDiscount(OrderAmount):c}";

        }
    }
}
