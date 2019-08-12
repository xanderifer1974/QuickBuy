using QuickBuy.Domain.Contratos;
using QuickBuy.Domain.Entidades;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        //Passa a instância do context para a classe pai
        public ProdutoRepository(QuickBuyContext quickBuiContext) : base(quickBuiContext)
        {
        }
    }
}
