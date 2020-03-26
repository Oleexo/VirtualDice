namespace VirtualDice.Races {
    public class RacialCapacity : IRacialCapacity {
        public RacialCapacity(string nameId, string descriptionId) {
            NameId        = nameId;
            DescriptionId = descriptionId;
        }
        public string NameId        { get; }
        public string DescriptionId { get; }
    }
}