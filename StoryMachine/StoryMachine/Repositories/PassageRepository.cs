using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;
using StoryMachine.Utilities;

namespace StoryMachine.Repositories
{
    class PassageRepository
    {
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
            List<Dictionary<string, string>> passagesFromDb = DatabaseHelper.Current.SelectColumns("SELECT id, story_id, title, passagetext FROM passage;");

            if (passagesFromDb == null)
            {
                return null;
            }

            List<Passage> passages = new List<Passage>();

            foreach (Dictionary<string, string> passageFromDb in passagesFromDb)
            {
                passages.Add(new Passage
                    {
                        Id = int.Parse(passageFromDb["id"]),
                        StoryId = int.Parse(passageFromDb["story_id"]),
                        Title = passageFromDb["title"],
                        Description = passageFromDb["passagetext"]
                    }
                );
            }

            return passages;
        }

        public List<Passage> GetAllPassagesByStoryId(int storyId)
        {
            return GetAllPassages().Where(passage => passage.StoryId == storyId).ToList();
        }


    }
}
