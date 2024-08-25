namespace WEB_APP.Domain.Core.Events;

public abstract record DomainEvent : IDomainEvent
{
    protected DomainEvent()
    {
        EventId = Guid.NewGuid();
        OccuerdOn = DateTime.UtcNow;
    }

    public Guid EventId { get; }

    public DateTime OccuerdOn { get; }
}
