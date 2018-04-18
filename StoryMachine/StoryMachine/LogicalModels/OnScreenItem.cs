using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;

namespace StoryMachine.LogicalModels
{
    public class OnScreenItem
    {
        public Passage CurrentPassage { get; set; }
        public List<Option> OnScreenOptions { get; set; }
    }
}
