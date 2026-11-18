using Cortex.Mediator.Notifications;
using pc212053u201621873.Shared.Domain.Model.Events;

namespace pc212053u201621873.Shared.Application.Internal.EventHandler;

public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent
{
}