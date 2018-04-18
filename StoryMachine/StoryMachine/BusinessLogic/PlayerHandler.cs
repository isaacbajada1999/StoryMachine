using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;
using StoryMachine.Repositories;

namespace StoryMachine.BusinessLogic
{
    public class PlayerHandler
    {
        PlayerDetailsRepository playerRepository = new PlayerDetailsRepository();

        public bool Login(string name)
        {
            // If user exists, log him in
            // If user doesn't exist, give a warning message
            
            PlayerDetails playerDetails = playerRepository.GetPlayerByName(name);

            if (playerDetails == null)
            {
                // Give warning
                return false;
            }
            else
            {
                ApplicationState.currentPlayer = playerDetails;
                return true;
            }
            
        }

        public bool Register(string name)
        {
            // If user exists, give a warning message
            // If user doesn't exist, create new user in database
            PlayerDetails playerDetails = playerRepository.GetPlayerByName(name);

            if (playerDetails == null)
            {
                playerRepository.AddPlayerDetails(name);
                return Login(name); // automatically login after register
            }
            else
            {
                // Give warning
                return false;
            }

        }
    }
}
