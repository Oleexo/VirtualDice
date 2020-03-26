using System;
using System.Threading.Tasks;
using VirtualDice.Games;

namespace VirtualDice.Data.Common {
    public interface IRepository<TEntity> where TEntity : IEntity {
        Task<TEntity> FindByIdAsync(Guid id);
        Task       CreateAsync(TEntity entity);
        Task       UpdateAsync(TEntity entity);
    }
}