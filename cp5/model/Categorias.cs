

namespace cp5.model
{
    public class Categorias
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public List<Tarefas> Tarefas { get; set; } = new();
    }
}
