using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualDice.Games;

namespace VirtualDice.Data.Players {
    public class GameMasterEntityTypeConfiguration : IEntityTypeConfiguration<GameMaster> {
        public void Configure(EntityTypeBuilder<GameMaster> builder) {
            
        }
    }
}