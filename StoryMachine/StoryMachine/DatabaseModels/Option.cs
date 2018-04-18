using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryMachine.DatabaseModels
{
    public class Option
    {
        public int Id { get; set; }
        public int PassageId { get; set; }
        public string Text { get; set; }
        public int RequiredOptionId { get; set; }
        public int DestPassageId { get; set; }
    }
}
