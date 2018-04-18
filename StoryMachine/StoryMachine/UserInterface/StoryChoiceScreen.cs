using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoryMachine.BusinessLogic;

namespace StoryMachine.UserInterface
{
    public partial class LoadStorys : StoryScreen
    {
        public LoadStorys()
        {
            InitializeComponent();
            loadToolStripMenuItem1.MouseHover += GetMenuItems;
        }


        private void GetMenuItems(object sender, EventArgs e)
        {
            loadToolStripMenuItem1.DropDownItems.Clear();
            List<ToolStripMenuItem> storyButtonsList = storyHandler
                .GetAllStoryNames()
                .Select(storyName => new ToolStripMenuItem(storyName))
                .ToList();

            storyButtonsList.ForEach(storyButton => storyButton.Click += storyClick);

            loadToolStripMenuItem1.DropDownItems.AddRange(storyButtonsList.ToArray());
        }

        private void storyClick(object sender, EventArgs e)
        {
            ApplicationState.currentStory = storyHandler.ChooseStory(sender.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            StoryFormStart SFS = new StoryFormStart();
            SFS.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            StoryFormStart SFS = new StoryFormStart();
            SFS.ShowDialog();
        }
    }
}

