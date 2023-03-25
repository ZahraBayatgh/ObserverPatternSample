using ObserverPatternSample.interfaces;
using ObserverPatternSample.Models;

namespace ObserverPatternSample.Services
{
    public class OrderService : IOrderService
    {
        public event Action<Order> OrderStateChanged;

        public void UpdateOrder(Order order)
        {
            //Some logic..

             OrderStateChanged?.Invoke(order);
        }

    }

}
