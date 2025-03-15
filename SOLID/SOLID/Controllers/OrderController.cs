using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SOLID.Interface;

namespace SOLID.Controllers
{
    [Route("[controller]")]
    
public class OrderController : Controller
{
    private readonly IOrderProcessor _orderProcessor;
    private readonly IOrderRepository _orderRepository;

    public OrderController(IOrderProcessor orderProcessor, IOrderRepository orderRepository)
    {
        _orderProcessor = orderProcessor;
        _orderRepository = orderRepository;
    }

    // Displays the order form
    public IActionResult PlaceOrder()
    {
        return View();
    }

    // Handles order submission
    [HttpPost]
    public IActionResult SubmitOrder(string productName, int quantity)
    {
        var order = new Order
        {
            OrderId = new Random().Next(1000, 9999), // Mock Order ID
            ProductName = productName,
            Quantity = quantity
        };

        _orderProcessor.ProcessOrder(order);
        _orderRepository.SaveOrder(order);

        // Pass order details to confirmation page
        ViewData["OrderId"] = order.OrderId;
        ViewData["ProductName"] = order.ProductName;
        ViewData["Quantity"] = order.Quantity;

        return View("OrderConfirmation");
    }
}
}