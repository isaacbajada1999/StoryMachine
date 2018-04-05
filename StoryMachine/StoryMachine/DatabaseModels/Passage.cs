using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryMachine.DatabaseModels
{
    class Passage
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
