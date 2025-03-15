using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.Interface;

namespace SOLID.Models
{
    public class EmailOrderProcessor : IOrderProcessor
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine($"📧 Order {order.OrderId} processed via email.");
    }
}
}