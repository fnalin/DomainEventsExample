using MonitorandoCargaTransporte.DependencyResolver;
using MonitorandoCargaTransporte.DomainEvent;
using MonitorandoCargaTransporte.DomainEvent.Events;
using MonitorandoCargaTransporte.Models;
using System;

namespace MonitorandoCargaTransporte
{
    class Program
    {
        static void Main()
        {
            //Resolvendo as dependências
            SimpleInjectorContainer.RegisterServices();

            //Preparando o envento
            var idCliente = 10;
            var idObjeto = 574;
            var encomenda = new Encomenda(idCliente, idObjeto);

            var fazerUmaEncomenda = new EncomendaRealizada(
                encomenda.ClienteId,
                encomenda.ObjetoId,
                encomenda.DataEntregaPrevista
            );

            //Realizando o evento
            DomainEvents.Raise(fazerUmaEncomenda);

            Console.ReadKey();
        }
    }
}
