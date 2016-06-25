using System;

namespace MonitorandoCargaTransporte.DomainEvent.Events
{
    public class EncomendaRealizada : IDomainEvent
    {
        public EncomendaRealizada(int clienteId, int objetoId, DateTime dataEntregaPrevista)
        {
            this.ClienteId = clienteId;
            this.ObjetoId = objetoId;
            this.DataEntregaPrevista = dataEntregaPrevista;
        }

        public int ClienteId { get; private set; }
        public int ObjetoId { get; private set; }
        public DateTime DataEntregaPrevista { get; private set; }
    }
}
