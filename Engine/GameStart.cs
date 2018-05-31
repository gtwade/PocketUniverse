using System;
using System.IO;

namespace PocketUniverse
{
    public class GameStart
    {
        public Database GameDb { get; set; }
        public Game MyGame { get; set; }
        public string UserDomain { get; set; }
        public string User { get; set; }
        public string DbPath { get; set; }
        public string DbName { get; set; }

        public void Start()
        {
            Start(string.Empty);
        }
        
        public void Start(string dbName)
        {
            UserDomain = Environment.UserDomainName;
            User = Environment.UserName;
            DbPath = "c:\\Users\\" + User + "\\AppData\\Roaming\\PocketUniverse\\";
            DbName = dbName;

            MyGame = new Game();

            if (string.Equals(dbName, string.Empty))
            {
                Console.Write("Would you like to (L)oad a game, start a (N)ew game, or (Q)uit? ");
                var command = Console.ReadLine();
                
                while (!string.Equals(command, "L") || !string.Equals(command, "N"))
                {
                    Console.WriteLine("Your response is not L, N, or Q.");
                    Console.Write("Would you like to (L)oad a game, start a (N)ew game, or (Q)uit? ");
                    command = Console.ReadLine();
                }

                switch(command.ToUpper())
                {
                    case "Q":
                        QuitGame();
                        break;
                    case "L":
                        LoadGame();
                        break;
                    case "N":
                        StartNewGame();
                        break;
                }
            }
            else
            {
                // user has specified a game save (db) name. Load it if it exists.
                LoadGame(DbName);
            }

            Loop();
        }

        public void StartNewGame()
        {
            Console.Write("Please enter a name to save the game under: ");
            DbName = Console.ReadLine();

             if (!Directory.Exists(DbPath))
            {
                Directory.CreateDirectory(DbPath);
            }
                
            CreateNewDb();
            CreateNewPC();
        }

        public void LoadGame()
        {
            Console.Write("What is the save name? ");
            DbName = Console.ReadLine();

            LoadGame(DbName);
        }

        public void LoadGame(string dbName)
        {

        }

        public void QuitGame()
        {

        }

        public void CreateNewDb()
        {
            Console.Write("Please enter a new game name: ");
            DbName = Console.ReadLine();
            
            if (MyGame.CreateGameDb(DbName, DbPath))
            {
                //MyGame.Db.SeedNewDb();
            }
            
            Console.WriteLine("New game " + DbName + " created. Let's get going! Press ENTER to continue.");
            Console.ReadLine();
        }

        public void CreateNewPC()
        {
            var player = new PlayerCharacter();
            Console.WriteLine("Let's create a new character for you.");
            MyGame.pc = new PlayerCharacter();
            Console.Write("Enter First Name: ");
            player.FirstName = Console.ReadLine();
            Console.Write("Now enter the last name: ");
            player.LastName = Console.ReadLine();

            // Fix this later
            Console.Write("What is your race? ");
            player.Race = Console.ReadLine();

            Console.Write("Gender: Just hit ENTER for now");
            player.Gender = GenderType.None;
            Console.ReadLine();
            
        }

        public void Loop()
        {
            string kmand = string.Empty;

            while(!string.Equals(kmand, "quit"))
            {
                Console.Write("Enter command: ");
                kmand = Console.ReadLine();
            }
            
            Console.Write("Bye!...");
            Console.ReadLine();
        }
    }
}