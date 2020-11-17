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

        public void AddCharacter(string name)
        {
            characterRepo.AddCharacter(name);
        }

        public void DeleteCharacter(int id)
        {
            characterRepo.DeleteCharacter(id);
        }

        public IList<Character> GetCharacterList()
        {
            return characterRepo.GetAllCharacters();
        }
    }
}
