using QuickBuy.Domain.Contratos;
using QuickBuy.Domain.Entidades;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
