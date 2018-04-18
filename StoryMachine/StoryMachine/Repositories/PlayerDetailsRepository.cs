using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;

namespace StoryMachine.Repositories
{
    class PlayerDetailsRepository
    {
        List<string> tempPlayer = new List<string>();

        public bool AddPlayerDetails(string name)
        {
            Console.WriteLine("Added player in the database: " + name);
            tempPlayer.Add(name);
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
            string foundPlayerName = tempPlayer.Where(playerName => playerName == name).FirstOrDefault();
            if (foundPlayerName == null)
            {
                return null;
            } else {
                return new PlayerDetails() { Name = foundPlayerName };
            }
        }

        public List<PlayerDetails> GetAllPlayers()
        {
            return null;
        }







    }

}
