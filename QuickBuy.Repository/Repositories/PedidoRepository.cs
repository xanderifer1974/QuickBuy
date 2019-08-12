using QuickBuy.Domain.Contratos;
using QuickBuy.Domain.Entidades;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(QuickBuyContext quickBuiContext) : base(quickBuiContext)
        {
        }
    }
}
