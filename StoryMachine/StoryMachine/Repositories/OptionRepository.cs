using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;
using StoryMachine.Utilities;

namespace StoryMachine.Repositories
{
    class OptionRepository
    {
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



        internal List<Option> GetOptionByPassageId(int passageId)
        {
            List<Dictionary<string, string>> optionsFromDb = DatabaseHelper.Current.SelectColumns("SELECT * FROM options WHERE passage_id = " + passageId + ";");
            DatabaseHelper.Current.SelectColumns("SELECT text FROM options WHERE passage_id = 2");




            if (optionsFromDb == null)
            {
                return null;
            }

            List<Option> options = new List<Option>();

            foreach (Dictionary<string, string> optionFromDb in optionsFromDb)
            {
                options.Add(new Option
                {
                    Id = int.Parse(optionFromDb["id"]),
                    PassageId = int.Parse(optionFromDb["passage_id"]),
                    RequiredOptionId = int.Parse(optionFromDb["requiredoption_id"]),
                    DestPassageId = int.Parse(optionFromDb["destpassage_id"]),
                    OptionText = optionFromDb["text"]
                }
                );
            }

            return options;
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
