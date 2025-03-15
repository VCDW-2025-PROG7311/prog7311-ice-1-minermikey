using SOLID.Interface;

public class SmsOrderProcessor : IOrderProcessor
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine($"📲 Order {order.OrderId} processed via SMS.");
    }
}
