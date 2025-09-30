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

        public void AdicionarCategoria(string nome)
        {
            var categoria = new Categorias { Nome = nome };
            _categoriaRepo.Add(categoria);
        }

        public IEnumerable<Categorias> ListarCategorias()
        {
            return _categoriaRepo.GetAll();
        }
    }
}
