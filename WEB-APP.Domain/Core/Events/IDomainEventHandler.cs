using MediatR;

namespace WEB_APP.Domain.Core.Events;

public interface IDomainEventHandler<in TDomainEvent> : INotificationHandler<TDomainEvent>
    where TDomainEvent : IDomainEvent
{

}
