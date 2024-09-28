using AsyncTaskQueueConsole.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskQueueConsole.Interfaces
{
    public interface IContabilizadorService
    {
        Task ProcessarTarefasAsync(IEnumerable<Contabilizador> contabilizador);
    }
}
