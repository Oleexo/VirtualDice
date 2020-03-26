using System;

namespace VirtualDice.Common {
    public class DiceExpression {
        public DiceExpression(uint quantity, int diceRange, int? modifier = null) {
            Quantity = quantity;
            DiceRange = diceRange;
            Modifier = modifier;
            Random = new Random();
        }

        public uint Quantity { get; }
        public int DiceRange { get; }
        public int? Modifier { get; }

        public override string ToString() {
            if (Modifier.HasValue) {
                return $"{Quantity}d{DiceRange}{Modifier}";
            }
            return $"{Quantity}d{DiceRange}";
        }

        public Random Random { get; set; }

        public int GetValue() {
            var result = 0;
            for (var i = 0; i < Quantity; i++) {
                result += Random.Next(1, DiceRange);
            }

            if (Modifier.HasValue) {
                result += Modifier.Value;
            }

            return result;
        }
    }
}