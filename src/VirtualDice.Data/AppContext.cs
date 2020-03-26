using Microsoft.EntityFrameworkCore;
using VirtualDice.Data.Games;
using VirtualDice.Data.Players;
using VirtualDice.Games;

namespace VirtualDice.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Game> Games => Set<Game>();

        public DbSet<Player> Players => Set<Player>();

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new GameEntityTypeConfiguration())
                        .ApplyConfiguration(new PlayerEntityTypeConfiguration())
                        .ApplyConfiguration(new GameMasterEntityTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
