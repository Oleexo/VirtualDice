using System.Threading.Tasks;

namespace VirtualDice.Data {
    internal class UnitOfWork : IUnitOfWork {
        private readonly AppContext _appContext;
        public UnitOfWork(AppContext appContext) {
            _appContext = appContext;
        }

        public Task CommitAsync() {
            return _appContext.SaveChangesAsync();
        }
    }
}