using System.Collections.Generic;
using VirtualDice.Common;
using VirtualDice.Profiles;
using VirtualDice.Races;

namespace VirtualDice {
    public class PlayerCharacter : ICharacter {
        private readonly List<ICapacity> _capacities;
        private          Characteristics _naturalCharacteristics;
        private          RaceInformation _raceInformation;

        public PlayerCharacter() {
            Characteristics = new Characteristics();
            RaceInformation = new Human();
        }

        public string Story { get; set; }

        public int Weight { get; set; }
        public int Age    { get; set; }
        public int Size   { get; set; }
        public CharacterGender Gender { get; set; }

        public RaceInformation RaceInformation {
            get => _raceInformation;
            set {
                Weight           = value.Weight.Min;
                Size             = value.Size.Min;
                Age              = value.StartAge;
                _raceInformation = value;
                OnCharacteristicsChanged();
            }
        }

        public IProfile Profile { get; set; }

        public IReadOnlyCollection<ICapacity> Capacities => _capacities;
        public string                         Name       { get; set; }
        public int                            Level      { get; set; }

        #region ICharacter

        IRaceInformation ICharacter.RaceInformation => RaceInformation;

        #endregion


        private void OnCharacteristicsChanged() {
            if (NaturalCharacteristics == null) {
                Characteristics = null;
                Modifiers = null;
                return;
            }
            if (RaceInformation == null) {
                Characteristics = new Characteristics(NaturalCharacteristics);
            }
            else {
                Characteristics = NaturalCharacteristics + RaceInformation.Modifiers;
            }
            Modifiers       = new Modifiers(Characteristics);
        }

        #region Characteristics

        public Characteristics NaturalCharacteristics {
            get => _naturalCharacteristics;
            set {
                _naturalCharacteristics = value;
                OnCharacteristicsChanged();
            }
        }

        public int[] NaturalCharacteristicsValues { get; set; }

        public ICharacteristics Characteristics { get; private set; }


        public IModifiers Modifiers { get; private set; }

        #endregion
    }
}