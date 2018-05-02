using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;
using StoryMachine.Utilities;

namespace StoryMachine.Repositories
{
    class PlayerDetailsRepository
    {
        public bool AddPlayerDetails(string name)
        {
            Console.WriteLine("Added player in the database: " + name);
            DatabaseHelper.Current.Insert("INSERT INTO playerdetails (name) VALUES ('" + name + "')");
            return true;
        }

        public bool DeletePlayerDetails(PlayerDetails PlayerDetails)
        {
            Console.WriteLine("Deleted player from the database: " + PlayerDetails.Name);
            return true;
        }

        public bool UpdatePlayerDetails(PlayerDetails PlayerDetails)
        {
            return true;
        }

        public PlayerDetails GetPlayerDetailsById(int id)
        {
            return null;
        }

        public PlayerDetails GetPlayerByName(string name)
        {
            Console.WriteLine("Retrieved player from the database with name: " + name);
            DatabaseHelper databaseHelper = DatabaseHelper.Current;

            string id = databaseHelper.SelectValue("SELECT id FROM playerdetails WHERE name = '" + name + "'");

            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }
            else
            {
                return new PlayerDetails() { Id = int.Parse(id), Name = name };
            }
        }

        public List<PlayerDetails> GetAllPlayers()
        {
            return null;
        }







    }

}
