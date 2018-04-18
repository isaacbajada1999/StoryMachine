using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;
using StoryMachine.LogicalModels;

namespace StoryMachine.BusinessLogic
{
    public class StateHandler
    {
        public OnScreenItem Load(PlayerDetails player, Story story)
        {
            return null;
        }

        public bool Save(PlayerDetails player, Story story, State state)
        {
            return false;
        }
    }
}
