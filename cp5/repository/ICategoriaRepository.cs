using cp5.model;


namespace cp5.repository
{
    public interface ICategoriaRepository
    {
        void Add(Categorias categoria);
        IEnumerable<Categorias> GetAll();
        Categorias? GetById(int id);
    }
}
