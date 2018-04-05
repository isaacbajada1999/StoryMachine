using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryMachine.DatabaseModels
{
    class Options
    {
        public int Id { get; set; }
        public int PassageId { get; set; }
        public string Text { get; set; }
        public int RequiredOptionId { get; set; }
        public int DeskPassageId { get; set; }

    }
}
