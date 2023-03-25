using ObserverPatternSample.Models;

namespace ObserverPatternSample.interfaces
{
    public interface IOrderService 
    {
        void UpdateOrder(Order order);
        event Action<Order> OrderStateChanged;
    }
}
