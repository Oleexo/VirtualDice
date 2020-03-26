using System.Collections.Generic;
using VirtualDice.Common;

namespace VirtualDice.Races {
    public abstract class RaceInformation : IRaceInformation {
        protected RaceInformation() {
            Genders = new[] {CharacterGender.Male, CharacterGender.Female};
        }

        public IRacialCapacity                      Capacity           { get; set; }
        public IReadOnlyCollection<CharacterGender> Genders            { get; set; }
        public string                               NameId             { get; set; }
        public int                                  StartAge           { get; set; }
        public int                                  LifeExpectancy     { get; set; }
        public (int Min, int Max)                   Size               { get; set; }
        public (int Min, int Max)                   Weight             { get; set; }
        public string                               SmallDescriptionId { get; set; }
        public ICharacteristics                     Modifiers          { get; set; }
    }
}