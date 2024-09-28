# AsyncTaskQueue

## Descrição

**AsyncTaskQueue** é um Console App que simula o processamento de uma fila de tarefas de forma assíncrona. Cada tarefa aguarda um tempo aleatório (entre 1 e 5 segundos) para ser processada, e ao final, exibe o ID da tarefa e o tempo que levou para ser executada. O projeto utiliza o conceito de programação assíncrona com `Task` e `Task.WhenAll`, permitindo que múltiplas tarefas sejam executadas simultaneamente.

## Objetivo

O objetivo deste projeto é demonstrar o uso de programação assíncrona, gerenciamento de múltiplas operações concorrentes e boas práticas de separação de responsabilidades em uma aplicação C#.

## Funcionalidades

- Criação de uma fila de tarefas.
- Processamento assíncrono de tarefas com tempo de execução variável.
- Exibição do tempo de execução e ID de cada tarefa.
- Processamento simultâneo de todas as tarefas utilizando `Task.WhenAll`.

## Tecnologias Utilizadas

- **C#**
- **.NET 7.0**
- Programação assíncrona com `Task` e `Task.WhenAll`

## Estrutura do Projeto

```bash
AsyncTaskQueue/
├── Dominio/
│   └── Tarefa.cs               # Define o modelo de dados da tarefa
├── Interfaces/
│   └── ITarefaServico.cs        # Define a interface para o serviço de processamento de tarefas
├── Servicos/
│   └── TarefaServico.cs         # Implementa o processamento de tarefas de forma assíncrona
├── Program.cs                   # Ponto de entrada da aplicação, gerencia a criação de tarefas
└── ConsoleAppFilaTarefas.csproj # Arquivo de projeto do .NET

## Pastas:
 - Damin: Contém a classe Tarefa, que representa uma tarefa com ID e tempo de processamento.
 - Interfaces: Define a interface ITarefaServico para o serviço que gerencia o processamento das tarefas.
 - Services: Implementa o serviço TarefaServico, que processa as tarefas de forma assíncrona.

## As tecnologias utilizadas no último projeto de fila de tarefas assíncronas foram:

1. C# (CSharp): A linguagem de programação usada para implementar o projeto.
2. .NET (Console App): O framework utilizado para criar a aplicação de console, fornecendo bibliotecas e suporte para programação assíncrona com Task.
3. Programação Assíncrona com Task: Utilização de Task e Task.WhenAll para a execução de múltiplas tarefas de forma simultânea e eficiente.
4. Gerenciamento de Threads: A capacidade de gerenciar várias operações concorrentes de forma não bloqueante usando o sistema de Tasks do .NET.