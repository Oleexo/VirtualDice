using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualDice.Games;

namespace VirtualDice.Data.Games {
    public class GameEntityTypeConfiguration : IEntityTypeConfiguration<Game> {
        public void Configure(EntityTypeBuilder<Game> builder) {
            builder.ToTable("Games");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Password).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Ignore(p => p.GameMasters);

            builder.HasMany(p => p.Players)
                   .WithOne(p => p.Game)
                   .HasForeignKey(p => p.GameId);
        }
    }
}