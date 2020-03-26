using System.Threading.Tasks;

namespace VirtualDice.Data {
    public interface IUnitOfWork {
        Task CommitAsync();
    }
}