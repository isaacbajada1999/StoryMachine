using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;
using StoryMachine.Utilities;

namespace StoryMachine.Repositories
{
    class StoryRepository
    {
        public bool AddStory(Story story)
        {
            return true;
        }

        public bool DeleteStory(Story story)
        {
            return true;
        }

        public bool UpdateStory(Story story)
        {
            return true;
        }

        public Story GetStoryById(int id)
        {
            string name = DatabaseHelper.Current.SelectValue("SELECT name FROM stories WHERE id = " + id);

            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            return new Story { Id = id, Name = name };
        }

        public Story GetStoryByName(string name)
        {
            string idFromDatabase = DatabaseHelper.Current.SelectValue("SELECT id FROM stories WHERE name = '" + name + "'");

            if (string.IsNullOrWhiteSpace(idFromDatabase))
            {
                return null;
            }

            int id = int.Parse(idFromDatabase);

            return new Story { Id = id, Name = name };
        }

        public List<Story> GetAllStories()
        {
            List<Dictionary<string, string>> storiesFromDb = DatabaseHelper.Current.SelectColumns("SELECT id, name FROM stories");
            
            if (storiesFromDb == null)
            {
                return null;
            }

            List<Story> stories = new List<Story>();

            foreach(Dictionary<string, string> storyFromDb in storiesFromDb)
            {
                stories.Add(new Story { Id = int.Parse(storyFromDb["id"]), Name = storyFromDb["name"]});
            }

            return stories;
        }


    }
}
