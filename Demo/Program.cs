namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Order Details => ");

            int orderId;
            bool IdParsed;
            do
            {
                Console.Write("OrderId: ");
                IdParsed = int.TryParse(Console.ReadLine(), out orderId);
            }
            while (!IdParsed);

            string name;
            do
            {
                Console.Write("CustomerName: ");
                name = Console.ReadLine()!;
            }
            while (string.IsNullOrWhiteSpace(name));

            decimal orderAmount;
            bool AmountParsed;
            do
            {
                Console.Write("OrderAmount: ");
                AmountParsed = decimal.TryParse(Console.ReadLine(), out orderAmount);
            }
            while (!AmountParsed);

            string orderType;
            do
            {
                Console.Write("OrderType => [Online | In-Store] : ");
                orderType = Console.ReadLine()!;
            }
            while (!(orderType == "Online" || orderType == "In-Store"));

            Order order;
            if (orderType == "Online") { order = new Order() { OrderId = orderId, CustomerName = name, OrderAmount = orderAmount, OrderProcessor = new OnlineOrderProcessor(orderId, name, orderAmount) }; }

            else if (orderType == "In-Store") { order = new Order() { OrderId = orderId, CustomerName = name, OrderAmount = orderAmount, OrderProcessor = new InStoreOrderProcessor(orderId, name, orderAmount) }; }
            else
                order = new Order();
                
            order.OrderProcessor.ProcessOrder();
            Console.WriteLine(order.OrderProcessor);



        }
    }
}
