using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Contratos
{
   public interface IBaseRepository<TEntity>: IDisposable where TEntity: class
    {
        void Aducuibar(TEntity entity);

        TEntity ObterPorId(int Id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);

    }
}
