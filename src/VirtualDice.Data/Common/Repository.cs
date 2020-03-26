using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualDice.Games;

namespace VirtualDice.Data.Common {
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity {
        private readonly AppContext     _appContext;
        protected        DbSet<TEntity> Entities => _appContext.Set<TEntity>();

        protected Repository(AppContext appContext) {
            _appContext = appContext;
        }

        public virtual async Task<TEntity> FindByIdAsync(Guid id) {
            return await Entities.FirstOrDefaultAsync(p => p.Id.Equals(id))
                                 .ConfigureAwait(false);
        }

        public async Task CreateAsync(TEntity entity) {
            await Entities.AddAsync(entity);
        }

        public Task UpdateAsync(TEntity entity) {
            try
            {
                Entities.Update(entity);
            }
            catch (InvalidOperationException) {
                var originalEntity = _appContext.Find<TEntity>(entity.Id);


                _appContext.Entry(originalEntity).CurrentValues.SetValues(entity);
                _appContext.Entry(originalEntity);
            }
            return Task.CompletedTask;
        }
    }
}