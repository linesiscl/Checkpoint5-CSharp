using cp5.model;
using cp5.repository;


namespace cp5.service
{
    public class TarefaService
    {
        private readonly ITarefaRepository _tarefaRepo;
        private readonly ICategoriaRepository _categoriaRepo;

        public TarefaService(ITarefaRepository tarefaRepo, ICategoriaRepository categoriaRepo)
        {
            _tarefaRepo = tarefaRepo;
            _categoriaRepo = categoriaRepo;
        }

        //método para adicionar uma tarefa a partir de uma categoria
        public void AdicionarTarefa(string titulo, string descricao, int categoriaId)
        {
            var categoria = _categoriaRepo.GetById(categoriaId);
            if (categoria == null) throw new Exception("Categoria não encontrada!");

            var tarefa = new Tarefas { Titulo = titulo, Descricao = descricao, CategoriaId = categoriaId };
            _tarefaRepo.Add(tarefa);
        }

        //lista as tarefas existentes
        public IEnumerable<Tarefas> ListarTarefas()
        {
            var tarefas = _tarefaRepo.GetAll();

            if (!tarefas.Any())
            {
                Console.WriteLine("Nenhuma tarefa cadastrada!");
            }

            return tarefas;
        }

        //atualizar a tarefa
        public void AtualizarTarefa(int id, string descricao, bool concluida)
        {
            var tarefa = _tarefaRepo.GetById(id);
            if (tarefa == null) throw new Exception("Tarefa não encontrada!");

            tarefa.Descricao = descricao;
            tarefa.Concluida = concluida;
            _tarefaRepo.Update(tarefa);
        }

        //excluir
        public void ExcluirTarefa(int id)
        {
            var tarefa = _tarefaRepo.GetById(id);
            if (tarefa == null) throw new Exception("Tarefa não encontrada!");

            _tarefaRepo.Delete(tarefa);
        }
    }
}
