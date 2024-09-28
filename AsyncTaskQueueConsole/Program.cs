using AsyncTaskQueueConsole.Domain;
using AsyncTaskQueueConsole.Interfaces;
using AsyncTaskQueueConsole.Services;
using System;
using System.Collections.Generic;

namespace AsyncTaskQueueConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IContabilizadorService contabilizadorService = new ContabilizadorService();
            List<Contabilizador> listaDeTarefas = GerarTarefas(10);
            await contabilizadorService.ProcessarTarefasAsync(listaDeTarefas);
        }

        static List<Contabilizador> GerarTarefas(int quantidade)
        {
            Random random = new();
            List<Contabilizador> tarefas = new();

            for (int i = 1; i <= quantidade; i++)
            {
                int tempoProcessamento = random.Next(1, 6); 
                tarefas.Add(new Contabilizador(i, tempoProcessamento));
            }

            return tarefas;
        }
    }
}
