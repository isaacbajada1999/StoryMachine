using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StoryMachine.BusinessLogic;
using StoryMachine.LogicalModels;

namespace StoryMachine.UserInterface
{
    public partial class StoryFormStart : StoryScreen
    {
        public StoryFormStart()
        {
            InitializeComponent();
            OnScreenItem onScreenItem = storyHandler.LoadStory(ApplicationState.currentStory.Name);
            passageTextBox.Text = onScreenItem.CurrentPassage.Description;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveGame = new SaveFileDialog ();
            if (SaveGame.ShowDialog() == DialogResult.OK)
            {

                using (Stream s = File.Open(SaveGame.FileName, FileMode.CreateNew))
                using (StreamWriter SW = new StreamWriter(s))

                {

                    SW.Write(StoryFormStart.MouseButtons);



                }




            }

        }
    }
}
