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
using StoryMachine.DatabaseModels;
using StoryMachine.Utilities;

namespace StoryMachine.UserInterface
{
    public partial class StoryFormStart : StoryScreen
    {
        private int id;
        private DatabaseHelper database;
        List<Button> buttons;

        public StoryFormStart()
        {
            InitializeComponent();
            buttons = new List<Button>{ option1, button5, button4, button3  };
            OnScreenItem onScreenItem = storyHandler.LoadStory(name: ApplicationState.currentStory.Name);
            LoadOnScreenItem(onScreenItem);
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

        private void StoryFormStart_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click( object sender, EventArgs e)
        {
            // Determine which Option was chosen (TODO)
            Option option = null;

            // Determine what onscreen item to load next (TODO)
            OnScreenItem onScreenItem = storyHandler.ChooseOption(option);

            // Update UI (READY)
            LoadOnScreenItem(onScreenItem);
        }

        private void passageTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            database = DatabaseHelper.Current;
            passageTextBox.Text = database.SelectValue("select storydescription from passage where passage_id = 2");

            //String test = database.Query("select optionnames from options where passage_id = 2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passageTextBox.Text = "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passageTextBox.Text = "4";
        }

        private void LoadOnScreenItem(OnScreenItem onScreenItem)
        {
            passageTextBox.Text = onScreenItem.CurrentPassage.Description;
            for (int i = 0; i < 4; i++)
            {
                Button currentButton = buttons[i];
                Option currentOption;

                if (onScreenItem.OnScreenOptions.Count < i + 1)
                {
                    currentOption = null;
                }
                else
                {
                    currentOption = onScreenItem.OnScreenOptions[i];
                }

                if (currentOption == null)
                {
                    currentButton.Visible = false;
                }
                else
                {
                    currentButton.Visible = true;
                    currentButton.Text = currentOption.OptionText;
                }
            }
        }

    }
    
}
