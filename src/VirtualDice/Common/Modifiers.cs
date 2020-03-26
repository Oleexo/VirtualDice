namespace VirtualDice.Common {
    public class Modifiers : IModifiers {
        public Modifiers(ICharacteristics characteristics) {
            Strength     = GetModifier(characteristics.Strength);
            Dexterity    = GetModifier(characteristics.Dexterity);
            Constitution = GetModifier(characteristics.Constitution);
            Intelligence = GetModifier(characteristics.Intelligence);
            Wisdom       = GetModifier(characteristics.Wisdom);
            Charisma     = GetModifier(characteristics.Charisma);
        }

        public int Strength     { get; }
        public int Dexterity    { get; }
        public int Constitution { get; }
        public int Intelligence { get; }
        public int Wisdom       { get; }
        public int Charisma     { get; }

        private int GetModifier(int value) {
            if (value <= 0) {
                return -5;
            }
            if (value >= 1 && value <= 3) {
                return -4;
            }

            if (value >= 4 && value <= 5) {
                return -3;
            }

            if (value >= 6 && value <= 7) {
                return -2;
            }

            if (value >= 8 && value <= 9) {
                return -1;
            }

            if (value >= 10 && value <= 11) {
                return 0;
            }

            if (value >= 12 && value <= 13) {
                return 1;
            }

            if (value >= 14 && value <= 15) {
                return 2;
            }

            if (value >= 16 && value <= 17) {
                return 3;
            }

            if (value >= 18 && value <= 19) {
                return 4;
            }

            if (value >= 20 && value <= 21) {
                return 5;
            }

            return 0;
        }
    }
}