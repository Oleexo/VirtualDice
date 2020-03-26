using System.ComponentModel.DataAnnotations;
using VirtualDice.Common;
using VirtualDice.Profiles;

namespace VirtualDice.Server.Pages.Game.CharacterEditor {
    public class PlayerCharacterModel {
        public PlayerCharacterModel(PlayerCharacter character) {
            Name = character.Name;
        }

        public PlayerCharacterModel() { }

        [Required]
        public string Name { get; set; }

        public string CharacterStory { get; set; }

        [Required]
        public IProfile Profile { get; set; }

        [Required]
        public Characteristics Characteristics { get; set; }

        public int[] CharacteristicsValues { get; set; }
    }
}