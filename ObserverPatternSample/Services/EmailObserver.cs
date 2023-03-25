using ObserverPatternSample.Models;

namespace ObserverPatternSample.Services
{
    public class EmailObserver
    {
        public void Send(Order order)
        {
            Console.WriteLine("Order No '{0}' status is updated to '{1}'. An email sent to customer.", 
                order.OrderNumber, order.OrderStatus.ToString());
        }
    }
}
