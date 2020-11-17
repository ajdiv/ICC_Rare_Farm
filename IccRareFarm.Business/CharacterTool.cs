using IccRareFarm.Repository;
using System.Collections.Generic;

namespace IccRareFarm.Business
{
    public class CharacterTool
    {
        private readonly ICharacterRepo characterRepo;

        public CharacterTool(ICharacterRepo charRepo)
        {
            characterRepo = charRepo;
        }

        public IList<Character> GetCharacterList()
        {
            return characterRepo.GetAllCharacters();
        }
    }
}
