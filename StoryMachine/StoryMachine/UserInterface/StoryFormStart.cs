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
using Npgsql;

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
            buttons = new List<Button> { option1, button5, button4, button3 };
            OnScreenItem onScreenItem = storyHandler.LoadStory(name: ApplicationState.currentStory.Name);
            LoadOnScreenItem(onScreenItem);




        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveGame = new SaveFileDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            handleOptionClick(sender, e);
        }


        private void handleOptionClick(object sender, EventArgs e)
        {
            // Determine which Option was chosen (TODO)
            string s = (sender as Button).Text;
            Option option = null;

            // Determine what onscreen item to load next (TODO)
            //OnScreenItem onScreenItem = storyHandler.ChooseOption();

            // Update UI (READY)
            // LoadOnScreenItem();

            // Determine what onscreen item to load next (TODO)
            // OnScreenItem onScreenItem = storyHandler.ChooseOption();

            // Update UI (READY)
            //LoadOnScreenItem("");

        }

        private void passageTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            //String test = database.ToString("select optionnames from options where passage_id = 2");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            passageTextBox.Text = DatabaseHelper.Current.SelectValue("SELECT passagetext FROM passage WHERE id = 2");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 2;
            do
            {

                passageTextBox.Text = DatabaseHelper.Current.SelectValue("SELECT passagetext FROM passage WHERE id = 2");
                passageTextBox.Text = DatabaseHelper.Current.SelectValue("SELECT passagetext FROM passage WHERE id = 3");

                id++;
            } while (id < 5);

           
            do
            {

                passageTextBox.Text = DatabaseHelper.Current.SelectValue("SELECT passagetext FROM passage WHERE id = 3");


            } while (id < 3);


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



       












        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

           

           


         




            }














        }
    
        
   
    






















