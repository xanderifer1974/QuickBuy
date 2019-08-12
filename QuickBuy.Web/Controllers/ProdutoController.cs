using Microsoft.AspNetCore.Mvc;
using QuickBuy.Domain.Contratos;
using QuickBuy.Domain.Entidades;
using System;

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

        /// <summary>
        /// Retorna todos os Produtos
        /// </summary>
        /// <returns></returns>        
        public IActionResult Get()
        {

            try
            {

                return Ok(_produtoRepository.ObterTodos());

            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        /// <summary>
        /// Insere um novo produto no banco de dados
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public IActionResult Post([FromBody]Produto produto)
        {

            try
            {

                _produtoRepository.Adicionar(produto);
                return Created("api/produto", produto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
