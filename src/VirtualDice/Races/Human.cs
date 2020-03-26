using VirtualDice.Common;

namespace VirtualDice.Races {
    public class Human : RaceInformation {
        public Human() {
            NameId             = "HumanRace";
            LifeExpectancy     = 100;
            Size               = (150, 200);
            Weight             = (40, 120);
            StartAge           = 18;
            SmallDescriptionId = "HumanRaceDescription";
            Modifiers          = new Characteristics();
        }
    }
}