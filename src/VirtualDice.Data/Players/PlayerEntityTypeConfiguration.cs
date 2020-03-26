using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using VirtualDice.Games;

namespace VirtualDice.Data.Players {
    public class PlayerEntityTypeConfiguration : IEntityTypeConfiguration<Player> {
        public void Configure(EntityTypeBuilder<Player> builder) {
            builder.ToTable("Players");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Password).IsRequired();
            builder.Property(p => p.GameId).IsRequired();
            builder.Property(p => p.Character)
                   .HasConversion<string>(v => v == null ? null : JsonConvert.SerializeObject(v),
                                          v => string.IsNullOrEmpty(v) ? null : JsonConvert.DeserializeObject<PlayerCharacter>(v));
            builder.HasDiscriminator<string>("Type");
        }
    }
}