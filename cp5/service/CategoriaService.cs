using cp5.model;
using cp5.repository;


namespace cp5.service
{
    public class CategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepo;

        public CategoriaService(ICategoriaRepository categoriaRepo)
        {
            _categoriaRepo = categoriaRepo;
        }

        //adicionar categorias para as tarefas
        public void AdicionarCategoria(string nome)
        {
            var categoria = new Categorias { Nome = nome };
            _categoriaRepo.Add(categoria);
        }

        //listar categorias existentes
        public IEnumerable<Categorias> ListarCategorias()
        {
            var categorias = _categoriaRepo.GetAll();

            if (!categorias.Any())
            {
                Console.WriteLine("Nenhuma categoria cadastrada!");
            }

            return categorias;
        }
    }
}
