using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;

namespace StoryMachine.Repositories
{
    class OptionRepository
    {
        List<Option> options = new List<Option>
        {
            new Option { Id = 0, RequiredOptionId = -1, PassageId = 0, DestPassageId = 1, Text = "Go To Shore"},
            new Option { Id = 1, RequiredOptionId = -1, PassageId = 0, DestPassageId = 2, Text = "Go To Pavement"}
        };

        public bool AddOption(Option Option)
        {
            return true;
        }

        public bool DeleteOption(Option Option)
        {
            return true;
        }

        public bool UpdateOption(Option Option)
        {
            return true;
        }

        internal List<Option> GetOptionByPassageId(int id)
        {
            return options.Where(option => option.PassageId == id).ToList();
        }

        public Option GetOptionById(int id)
        {
            return null;
        }

        public List<Option> GetAllOptions()
        {
            return null;
        }

    }
}
