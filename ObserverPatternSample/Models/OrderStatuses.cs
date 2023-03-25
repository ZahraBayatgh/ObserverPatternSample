namespace ObserverPatternSample.Models
{
    public enum OrderStatuses
    {
        PendingPayment = 1,
        OnHold = 2,
        Processing = 3,
        Shipped = 4,
        Cancelled = 5,
        Refunded = 6,
        Failed = 7,
        Completed = 8
    }
}
