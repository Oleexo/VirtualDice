using VirtualDice.Common;

namespace VirtualDice.Races {
    public class Gnome : RaceInformation
    {
        public Gnome()
        {
            NameId             = "GnomeRace";
            LifeExpectancy     = 250;
            Size               = (100, 120);
            Weight             = (30, 50);
            StartAge           = 40;
            SmallDescriptionId = "GnomeRaceDescription";
            Modifiers = new Characteristics
            {
                Strength     = -2,
                Intelligence = 2
            };
        }
    }
}