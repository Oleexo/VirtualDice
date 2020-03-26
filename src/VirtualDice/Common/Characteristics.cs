namespace VirtualDice.Common {
    public class Characteristics : ICharacteristics {
        public Characteristics(ICharacteristics characteristics) {
            Strength = characteristics.Strength;
            Dexterity = characteristics.Dexterity;
            Constitution = characteristics.Constitution;
            Intelligence = characteristics.Intelligence;
            Wisdom = characteristics.Wisdom;
            Charisma = characteristics.Charisma;
        }

        public Characteristics() {

        }

        public int Strength     { get; set; }
        public int Dexterity    { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom       { get; set; }
        public int Charisma     { get; set; }

        public static Characteristics operator +(Characteristics a, ICharacteristics b) {
            return new Characteristics {
                Charisma     = a.Charisma     + b.Charisma,
                Constitution = a.Constitution + b.Constitution,
                Dexterity    = a.Dexterity    + b.Dexterity,
                Intelligence = a.Intelligence + b.Intelligence,
                Strength     = a.Strength     + b.Strength,
                Wisdom       = a.Wisdom       + b.Wisdom
            };
        }
    }
}