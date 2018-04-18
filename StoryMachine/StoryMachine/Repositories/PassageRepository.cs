using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;

namespace StoryMachine.Repositories
{
    class PassageRepository
    {
        List<Passage> passages = new List<Passage>
        {
            new Passage { Id = 0, StoryId = 0, Title = "At the beach", Description = "You are on the beach. What do you do?" },
            new Passage { Id = 1, StoryId = 0, Title = "At the shore line", Description = "You are on the shore line. What do you do?" },
            new Passage { Id = 2, StoryId = 0, Title = "On the pavement", Description = "You exited the beach and are now on the pavement. End of story." }
        };

        public bool AddPassage(Passage Passage)
        {
            return true;
        }

        public bool DeletePassage(Passage Passage)
        {
            return true;
        }

        public bool UpdatePassage(Passage Passage)
        {
            return true;
        }

        public Passage GetPassageById(int id)
        {
            return null;
        }

        public List<Passage> GetAllPassages()
        {
            return passages;
        }

        public List<Passage> GetAllPassagesByStoryId(int storyId)
        {
            return GetAllPassages().Where(passage => passage.StoryId == storyId).ToList();
        }


    }
}
