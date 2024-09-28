using AsyncTaskQueueConsole.Domain;
using AsyncTaskQueueConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskQueueConsole.Services
{
    public class ContabilizadorService : IContabilizadorService
    {
        public async Task ProcessarTarefasAsync(IEnumerable<Contabilizador> contabilizador)
        {
            var listaDeTarefas = contabilizador.Select(t => ProcessarTarefaAsync(t)).ToList();
            await Task.WhenAll(listaDeTarefas);

            Console.WriteLine("\nTodas as tarefas foram concluídas.");
        }

        private async Task ProcessarTarefaAsync(Contabilizador contabilizador)
        {
            await Task.Delay(contabilizador.TempoProcessamento * 1000);
            Console.WriteLine($"A tarefa com o ID: {contabilizador.Id} foi processada em {contabilizador.TempoProcessamento} segundos.");
        }
    }
}
