using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryMachine.DatabaseModels
{
    public class State
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int StoryId { get; set; }
        public int PassageId { get; set; }

    }
}
