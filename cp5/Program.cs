using cp5.data;
using cp5.repository;
using cp5.service;


using var db = new AppDbContext();
var categoriaRepo = new CategoriaRepository(db);
var tarefaRepo = new TarefaRepository(db);

var categoriaService = new CategoriaService(categoriaRepo);
var tarefaService = new TarefaService(tarefaRepo, categoriaRepo);

bool rodando = true;

while (rodando)
{
    Console.WriteLine("\n*** Lista de Tarefas ***");
    Console.WriteLine("1 - Adicionar Categoria");
    Console.WriteLine("2 - Listar Categorias");
    Console.WriteLine("3 - Adicionar Tarefa");
    Console.WriteLine("4 - Listar Tarefas");
    Console.WriteLine("5 - Atualizar Tarefa");
    Console.WriteLine("6 - Excluir Tarefa");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");
    var opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
                Console.Write("Nome da categoria: ");
                categoriaService.AdicionarCategoria(Console.ReadLine()!);
                Console.WriteLine("Categoria adicionada!");
                break;

            case "2":
                foreach (var cat in categoriaService.ListarCategorias())
                    Console.WriteLine($"{cat.Id} - {cat.Nome}");
                break;

            case "3":
                Console.Write("Título: ");
                var titulo = Console.ReadLine();
                Console.Write("Descrição: ");
                var desc = Console.ReadLine();
                Console.Write("Id da categoria: ");
                var catId = int.Parse(Console.ReadLine()!);
                tarefaService.AdicionarTarefa(titulo!, desc!, catId);
                Console.WriteLine("Tarefa adicionada!");
                break;

            case "4":
                foreach (var t in tarefaService.ListarTarefas())
                    Console.WriteLine($"{t.Id} - {t.Titulo} | {t.Descricao} | Concluída: {t.Concluida}");
                break;

            case "5":
                Console.Write("Id da tarefa: ");
                var id = int.Parse(Console.ReadLine()!);
                Console.Write("Nova descrição: ");
                var novaDesc = Console.ReadLine();
                Console.Write("Concluída? (s/n): ");
                bool concluida = Console.ReadLine()!.ToLower() == "s";
                tarefaService.AtualizarTarefa(id, novaDesc!, concluida);
                Console.WriteLine("Tarefa atualizada!");
                break;

            case "6":
                Console.Write("Id da tarefa: ");
                var idDel = int.Parse(Console.ReadLine()!);
                tarefaService.ExcluirTarefa(idDel);
                Console.WriteLine("Tarefa excluída!");
                break;

            case "0":
                rodando = false;
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

