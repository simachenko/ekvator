using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ValueGeneration;
namespace DAL.IRepos
{
    public interface IGenericRepos<TEntity>
    {
        Task<TEntity> GetAsync(int Id);
        Task CreateAsync(TEntity item);
        Task<IEnumerable<TEntity>> GetAsync();
        //Task<IEnumerable<TEntity>> GetAsync(Func<TEntity, bool> predicate);
        //Task<bool> RemoveAsync(TEntity item);
        //Task<bool> RemoveAsync(int Id);
        //Task<bool> UpdateAsync(TEntity item);

        TEntity Get(int Id);
        void Create(TEntity item);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Remove(int Id);
        void Update(TEntity item);
    }
}
