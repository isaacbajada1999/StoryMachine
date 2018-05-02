using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryMachine.DatabaseModels
{
    public class State
    {
        public int id { get; set; }
        public int playerid { get; set; }
        public int storyid { get; set; }
        public int passageid { get; set; }

    }
}
