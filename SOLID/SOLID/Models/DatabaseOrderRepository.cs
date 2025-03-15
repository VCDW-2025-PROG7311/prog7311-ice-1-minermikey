using SOLID.Interface;

public class DatabaseOrderRepository : IOrderRepository
{
    public void SaveOrder(Order order)
    {
        Console.WriteLine($"💾 Order {order.OrderId} saved to database.");
    }
}
