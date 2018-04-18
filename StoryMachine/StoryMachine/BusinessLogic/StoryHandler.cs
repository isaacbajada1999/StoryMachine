using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryMachine.DatabaseModels;
using StoryMachine.LogicalModels;
using StoryMachine.Repositories;

namespace StoryMachine.BusinessLogic
{
    public class StoryHandler
    {
        private StoryRepository storyRepository = new StoryRepository();
        private PassageRepository passageRepository = new PassageRepository();
        private OptionRepository optionRepository = new OptionRepository();

        public OnScreenItem LoadStory(string name)
        {
            Story story = storyRepository.GetStoryByName(name);
            Passage passage = passageRepository.GetAllPassagesByStoryId(story.Id).FirstOrDefault();
            List<Option> options = optionRepository.GetOptionByPassageId(passage.Id);

            return new OnScreenItem
            {
                CurrentPassage = passage,
                OnScreenOptions = options
            };
        }

        public List<string> GetAllStoryNames()
        {
            List<Story> stories = storyRepository.GetAllStories();
            List<string> storyNames = new List<string>();

            foreach(Story story in stories) {
                storyNames.Add(story.Name);
            }
            
            return storyNames;
        }

        internal Story ChooseStory(string storyName)
        {
            return storyRepository.GetStoryByName(storyName);
        }

        public OnScreenItem ChooseOption(Option option)
        {
            return null;
        }
    }
}
