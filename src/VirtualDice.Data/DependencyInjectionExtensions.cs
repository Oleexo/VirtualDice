using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VirtualDice.Data.Games;
using VirtualDice.Data.Players;

namespace VirtualDice.Data {
    public static class DependencyInjectionExtensions {
        public static IServiceCollection AddOrm(this IServiceCollection services, IConfiguration configuration) {
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<AppContext>(o => { o.UseSqlite(configuration.GetConnectionString("Sqlite")); });
            return services;
        }
    }
}