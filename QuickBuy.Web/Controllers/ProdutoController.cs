using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contratos;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController: Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
