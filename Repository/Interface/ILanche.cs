using Site_loja.Models;

namespace Site_loja.Repository.Interface
{
    public interface ILanche
    {
        IEnumerable<Lanche> Lanches {get;}
        IEnumerable<Lanche> LanchesPreferidos {get;}
        Lanche GetLancheById(int id);
    }
}