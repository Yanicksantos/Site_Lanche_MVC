using Microsoft.EntityFrameworkCore;
using Site_loja.Data;
using Site_loja.Models;

namespace Site_loja.Repository.Interface
{
    public class LancheRepository : ILanche
    {
        private readonly AppDbContext _lanches;

        public LancheRepository(AppDbContext lanches)
        {
            _lanches = lanches;
        }

        public IEnumerable<Lanche> Lanches => _lanches.Lanches.Include(ctr => ctr.categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _lanches.Lanches
        .Where(pref => pref.IsPreferido)
        .Include(ctr => ctr.categoria);

        public Lanche GetLancheById(int id)
        {
            return _lanches.Lanches.FirstOrDefault(LancheId => LancheId.Id == id);
        }
    }
}