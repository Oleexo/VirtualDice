using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Options;
using VirtualDice.Races;

namespace VirtualDice.Games.Races {
    public interface IRaceService {
        IReadOnlyCollection<RaceInformation> Races { get; }
    }

    public class RaceService : IRaceService {
        private readonly RaceInformation[] _raceInformations;
        public RaceService(IOptions<RaceServiceOptions> options) {
            _raceInformations = options.Value.Assemblies
                                       .SelectMany(a => a.GetTypes().Where(p => typeof(IRaceInformation).IsAssignableFrom(p) && p.IsClass && !p.IsAbstract))
                                       .Select(p => Activator.CreateInstance(p) as RaceInformation)
                                       .Where(p => p != null)
                                       .ToArray();

        }

        public IReadOnlyCollection<RaceInformation> Races => _raceInformations;
    }

    public class RaceServiceOptions {
        private readonly List<Assembly> _assemblies;

        public RaceServiceOptions() {
            _assemblies = new List<Assembly>();
        }

        public IReadOnlyCollection<Assembly> Assemblies => _assemblies;

        public void AddAssembly<T>() {
            _assemblies.Add(typeof(T).Assembly);
        }
    }
}