using SOLID.Interface;

public class FileOrderRepository : IOrderRepository
{
    public void SaveOrder(Order order)
    {
        Console.WriteLine($"📂 Order {order.OrderId} saved to file.");
    }
}
