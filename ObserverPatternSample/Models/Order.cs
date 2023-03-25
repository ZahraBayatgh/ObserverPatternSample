namespace ObserverPatternSample.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public OrderStatuses OrderStatus { get; set; }
    }
}
