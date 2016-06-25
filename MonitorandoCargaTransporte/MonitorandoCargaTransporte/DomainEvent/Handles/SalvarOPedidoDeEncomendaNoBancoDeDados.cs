using MonitorandoCargaTransporte.DomainEvent.Events;
using System;

namespace MonitorandoCargaTransporte.DomainEvent.Handles
{
    public class SalvarOPedidoDeEncomendaNoBancoDeDados : IHandle<EncomendaRealizada>
    {
        public void Handle(EncomendaRealizada args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Encomenda {0} do cliente {1} salva no banco",
                args.ObjetoId, args.ClienteId);
        }
    }
}
