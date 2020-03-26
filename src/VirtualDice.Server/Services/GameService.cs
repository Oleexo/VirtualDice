using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using VirtualDice.Data;
using VirtualDice.Data.Games;
using VirtualDice.Data.Players;
using VirtualDice.Games;

namespace VirtualDice.Server.Services {
    public class GameService : IGameService {
        private static readonly List<Game>      Games = new List<Game>();
        private readonly        IGameRepository _gameRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly        IUnitOfWork     _unitOfWork;

        public GameService(IGameRepository gameRepository,
                           IPlayerRepository playerRepository,
                           IUnitOfWork unitOfWork) {
            _gameRepository = gameRepository;
            _playerRepository = playerRepository;
            _unitOfWork     = unitOfWork;
        }

        public bool IsRunningGame => Games.Any();

        public async Task CreateAsync([NotNull] Game game) {
            if (game == null) {
                Debug.WriteLine("Error trying to create a null game.");
                return;
            }
            await _gameRepository.CreateAsync(game);
            await _unitOfWork.CommitAsync();
            Games.Add(game);
        }

        public async Task<IGame> FindByIdAsync(Guid id) {
#if DEBUG
            if (id.Equals(Guid.Empty)) {
                return await _gameRepository.FindByIdAsync(id);
            }
#endif
            var game = Games.FirstOrDefault(p => p.Id.Equals(id));
            if (game == null) {
                game = await _gameRepository.FindByIdAsync(id);
                if (game != null) {
                    Games.Add(game);
                }
            }

            return game;
        }

        public async Task SaveAsync(IGame game) {
            await _gameRepository.UpdateAsync(game as Game)
                                 .ConfigureAwait(false);
            await _unitOfWork.CommitAsync();
        }

        public async Task SaveAsync(IGame game, IPlayer player) {
            await _playerRepository.UpdateAsync(player as Player)
                                   .ConfigureAwait(false);
            await _unitOfWork.CommitAsync();
        }

        public async Task AddPlayerToGame(IGame game, Player player) {
            var currentGame = Games.First(p => p.Id.Equals(game.Id));

            currentGame.Add(player);
            await _playerRepository.CreateAsync(player);
            await _unitOfWork.CommitAsync();
        }
    }
}