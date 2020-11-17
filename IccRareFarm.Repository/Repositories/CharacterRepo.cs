using LiteDB;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IccRareFarm.Repository
{
    public class CharacterRepo :ICharacterRepo
    {
        private string FileLocation { get; }
        private const string CollectionName = "characters";

        public CharacterRepo()
        {
            FileLocation = Path.GetTempPath() + "test.db";
        }

        public IList<Character> GetAllCharacters() 
        {
            using var db = new LiteDatabase(FileLocation);
            var collection = db.GetCollection<Character>(CollectionName);
            var characters = collection.FindAll().ToList();
            return characters;
        }
    }
}
