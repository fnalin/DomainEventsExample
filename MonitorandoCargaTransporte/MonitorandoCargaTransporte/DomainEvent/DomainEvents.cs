using MonitorandoCargaTransporte.DependencyResolver;
using MonitorandoCargaTransporte.DomainEvent.Events;
using MonitorandoCargaTransporte.DomainEvent.Handles;

namespace MonitorandoCargaTransporte.DomainEvent
{
    public static class DomainEvents
    {
        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            var handles = SimpleInjectorContainer.GetContainer().GetAllInstances<IHandle<T>>();

            foreach (var handle in handles)
            {
                handle.Handle(evento);
            }
        }
    }
}
