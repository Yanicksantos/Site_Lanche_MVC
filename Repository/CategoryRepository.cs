using Site_loja.Data;
using Site_loja.Models;
using Site_loja.Repository.Interface;

namespace Site_loja.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}