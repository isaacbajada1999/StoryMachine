using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;

namespace StoryMachine.Repositories
{
    class StoryRepository
    {
        List<Story> stories = new List<Story>
        {
            new Story() {Name = "Baywatch", Id = 0},
            new Story() {Name = "Sherlock", Id = 1}
        };

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
            return stories.Where(story => story.Id == id).FirstOrDefault();
        }

        public Story GetStoryByName(string name)
        {
            return stories.Where(story => story.Name == name).FirstOrDefault();
        }

        public List<Story> GetAllStories()
        {
            return stories;
        }


    }
}
