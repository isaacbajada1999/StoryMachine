using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoryMachine.BusinessLogic;

namespace StoryMachine.UserInterface
{
    public class StoryScreen : Form
    {
        protected static PlayerHandler playerHandler = new PlayerHandler();
        protected static StoryHandler storyHandler = new StoryHandler();
    }
}
