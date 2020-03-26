using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualDice.Data.Common;
using VirtualDice.Games;

namespace VirtualDice.Data.Games {
    internal class GameRepository : Repository<Game>, IGameRepository {

        public GameRepository(AppContext appContext) : base(appContext) {
        }


        public override async Task<Game> FindByIdAsync(Guid id) {
#if DEBUG
            if (id.Equals(Guid.Empty)) {
                return await Entities.FirstOrDefaultAsync();
            }
#endif
            return await Entities.Include(p => p.Players)
                                 .FirstOrDefaultAsync(p => p.Id.Equals(id))
                                 .ConfigureAwait(false);
        }

    }
}