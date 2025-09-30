using cp5.data;
using cp5.model;


namespace cp5.repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly AppDbContext _context;

        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Tarefas tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }

        public IEnumerable<Tarefas> GetAll() => _context.Tarefas.ToList();

        public Tarefas? GetById(int id) => _context.Tarefas.Find(id);

        public void Update(Tarefas tarefa)
        {
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
        }

        public void Delete(Tarefas tarefa)
        {
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
        }
    }
}
