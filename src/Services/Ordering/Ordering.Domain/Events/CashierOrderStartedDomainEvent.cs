namespace Ordering.Domain.Events;
public class CashierOrderStartedDomainEvent : INotification
{
    public Guid SessionID { get; set; }

    public string CashierName { get; set; }

    public string UserId { get; }
    public string UserName { get; }
}
