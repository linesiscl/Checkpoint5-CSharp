

namespace cp5.model
{
    public class Tarefas
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public bool Concluida { get; set; } = false;

        
        public int CategoriaId { get; set; }
        public Categorias? Categorias { get; set; }
    }
}
