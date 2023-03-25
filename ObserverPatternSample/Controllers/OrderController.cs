using Microsoft.AspNetCore.Mvc;
using ObserverPatternSample.Services;
using ObserverPatternSample.Models;
using ObserverPatternSample.interfaces;

namespace ObserverPatternSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult UpdateOder(Order order)
        {
            Console.WriteLine("Attaching Observers...");

            var smsObserver = new SmsObserver();
            var emailObserver = new EmailObserver();

            _orderService.OrderStateChanged += smsObserver.Send;
            _orderService.OrderStateChanged += emailObserver.Send;
          //  _orderService.OrderStateChanged -= emailObserver.Send;

            Console.WriteLine("Updating Order Status...");

            _orderService.UpdateOrder(order);

            return Ok(order);
        }

    }
}
