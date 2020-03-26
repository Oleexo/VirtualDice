using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualDice.Data.Common;
using VirtualDice.Games;

namespace VirtualDice.Data.Players {
    class PlayerRepository : Repository<Player>, IPlayerRepository {
        public PlayerRepository(AppContext appContext) : base(appContext) { }
        public override async Task<Player> FindByIdAsync(Guid id) {
            return await Entities.Include(p => p.Game)
                                 .FirstOrDefaultAsync(p => p.Id.Equals(id))
                                 .ConfigureAwait(false);
        }
    }
}