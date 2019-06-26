using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.IRepos
{
    public interface IGenericRepos<TEntity>
    {
        TEntity Get(int Id);
        void Create(TEntity item);
        IEnumerable<TEntity> Get();
        //ICollection<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Remove(int Id);
        void Update(TEntity item);
    }
}
