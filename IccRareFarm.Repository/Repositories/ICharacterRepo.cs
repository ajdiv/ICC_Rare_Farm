using System.Collections.Generic;

namespace IccRareFarm.Repository
{
    public interface ICharacterRepo
    {
        void AddCharacter(string name);
        void DeleteCharacter(int id);
        IList<Character> GetAllCharacters();
    }
}
