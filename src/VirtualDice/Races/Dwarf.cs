using VirtualDice.Common;

namespace VirtualDice.Races {
    public class Dwarf : RaceInformation {
        public Dwarf() {
            NameId             = "DwarfRace";
            LifeExpectancy     = 400;
            Size               = (115, 135);
            Weight             = (50, 100);
            StartAge           = 40;
            SmallDescriptionId = "DwarfRaceDescription";
            Modifiers = new Characteristics {
                Dexterity    = -2,
                Constitution = 2
            };
        }
    }
}