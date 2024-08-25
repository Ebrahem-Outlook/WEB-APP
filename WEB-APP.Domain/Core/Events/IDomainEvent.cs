using MediatR;

namespace WEB_APP.Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid EventId { get; }
    DateTime OccuerdOn { get; }
}
