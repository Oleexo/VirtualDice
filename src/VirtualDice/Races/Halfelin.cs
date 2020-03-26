using VirtualDice.Common;

namespace VirtualDice.Races {
    public class Halfelin : RaceInformation {
        public Halfelin() {
            NameId             = "HalfelinRace";
            LifeExpectancy     = 150;
            Size               = (80, 100);
            Weight             = (20, 30);
            StartAge           = 20;
            SmallDescriptionId = "HalfelinRaceDescription";
            Modifiers = new Characteristics {
                Strength  = -2,
                Dexterity = 2
            };
        }
    }
}