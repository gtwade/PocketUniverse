using System;

namespace PocketUniverse
{
    public class Game
    {
        public Database Db { get; set; }

        public string SaveName { get; set; }

        public DateTime DateLastSaved { get; set; }

        public DateTime DateCreated { get; set; }

        public PlayerCharacter pc { get; set; }

        #region Methods
        public bool CreateGameDb(string name, string path)
        {
            try
            {
                Db = new Database(name, path);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

/*
        public Database LoadGameDb(string name)
        {
            
        }

        public bool SeedNewDb()
        {

        }

        public bool SaveGame()
        {

        }
        */
        #endregion
    }

    
};