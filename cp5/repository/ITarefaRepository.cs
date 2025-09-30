using cp5.model;


namespace cp5.repository
{
    public interface ITarefaRepository
    {
        void Add(Tarefas tarefa);
        IEnumerable<Tarefas> GetAll();
        Tarefas? GetById(int id);
        void Update(Tarefas tarefa);
        void Delete(Tarefas tarefa);
    }
}
