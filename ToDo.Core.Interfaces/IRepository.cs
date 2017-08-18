using System.Collections.Generic;

namespace ToDo.Core.Interfaces
{
    public interface IRepository<TKey, TEntity>
    {
        TEntity Save(TEntity entity);

        TEntity Get(TKey id);

        IEnumerable<TEntity> GetAll();

        bool Delete(TKey id);
    }
}