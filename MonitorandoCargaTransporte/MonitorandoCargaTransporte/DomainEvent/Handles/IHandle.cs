using MonitorandoCargaTransporte.DomainEvent.Events;

namespace MonitorandoCargaTransporte.DomainEvent.Handles
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}
