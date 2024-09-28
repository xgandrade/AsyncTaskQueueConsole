using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskQueueConsole.Domain
{
    public class Contabilizador
    {
        public int Id { get; set; }
        public int TempoProcessamento { get; set; }

        public Contabilizador() { }

        public Contabilizador(int id, int tempoProcessamento)
        {
            Id = id;
            TempoProcessamento = tempoProcessamento;
        }
    }
}
