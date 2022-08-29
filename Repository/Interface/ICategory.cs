using Site_loja.Models;

namespace Site_loja.Repository.Interface
{
    public interface ICategory
    {
        IEnumerable<Categoria> Categorias {get;}
    }
}