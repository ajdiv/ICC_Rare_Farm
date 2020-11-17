using System.Collections.Generic;

namespace IccRareFarm.Repository
{
    public interface ICharacterRepo
    {
        IList<Character> GetAllCharacters();
    }
}
