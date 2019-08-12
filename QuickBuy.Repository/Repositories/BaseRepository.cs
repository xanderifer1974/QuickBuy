using System.Collections.Generic;
using System.Linq;
using QuickBuy.Domain.Contratos;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Adicionando a referência a classe dbcontext
        /// </summary>
        private readonly QuickBuyContext _quickBuyContext;

        public BaseRepository(QuickBuyContext quickBuiContext)
        {

            _quickBuyContext = quickBuiContext;

        }

        public void Adicionar(TEntity entity)
        {
            _quickBuyContext.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }       

        public TEntity ObterPorId(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _quickBuyContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
