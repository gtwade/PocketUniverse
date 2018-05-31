using System;
using LiteDB;

namespace PocketUniverse
{
    public class Database : IDisposable
    {
        public LiteDatabase Db { get; set; }

        public Database(string name, string path)
        {
            name += name + ".db";
            Db = new LiteDatabase(path + name);

           /*  Db.GetCollection<Map>("maps");
            Db.GetCollection<Thing>("things");
            Db.GetCollection<NonPlayerCharacter>("npcs");
            Db.GetCollection<Word>("words");
            Db.GetCollection<Word>("userWords");

            var getWord = new Word
            {
                Type = WordType.Verb,
                Name = "get",
                Value = "get"
            };

            var col = Db.GetCollection<Word>("words");
            col.Insert(getWord); */
        }

        public void Dispose()
        {
            
        }
    }
}