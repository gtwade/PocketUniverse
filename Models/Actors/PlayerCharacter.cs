using System;
using System.Linq;
using LiteDB;

namespace PocketUniverse
{
    public class PlayerCharacter : Actor
    {
        #region Properties
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Database CharacterDb = new Database("character", @"c:\temp");
        #endregion

        public PlayerCharacter()
        {
            
        }
        public PlayerCharacter(string firstName, string lastName, GenderType gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

        public void AddPlayerCharacter(PlayerCharacter pc)
        {
            using(CharacterDb)
            {
                //CharacterDb.Insert(pc);
            }
        }

    }

}