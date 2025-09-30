using cp5.data;
using cp5.model;


namespace cp5.repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Categorias categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public IEnumerable<Categorias> GetAll() => _context.Categorias.ToList();

        public Categorias? GetById(int id) => _context.Categorias.Find(id);
    }
}
