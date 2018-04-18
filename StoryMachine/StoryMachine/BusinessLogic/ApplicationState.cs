using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;

namespace StoryMachine.BusinessLogic
{
    class ApplicationState
    {
        public static PlayerDetails currentPlayer = null;
        public static Story currentStory = null;
    }
}
