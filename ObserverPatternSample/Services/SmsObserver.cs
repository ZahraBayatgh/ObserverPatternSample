using ObserverPatternSample.Models;

namespace ObserverPatternSample.Services
{
    public class SmsObserver 
    {
        public void Send(Order order)
        {
            Console.WriteLine("Order No '{0}' status is updated to '{1}'. SMS message sent to customer.",
                order.OrderNumber, order.OrderStatus.ToString());
        }
    }
}
