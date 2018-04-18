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
    public partial class LoadStory1 : StoryScreen
    {
        public LoadStory1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TextRegister.Text;
            bool isSuccessful = playerHandler.Register(name);

            if(!isSuccessful)
            {
                MessageBox.Show("A user with name " + name + " already exists.");
            } else
            {

                MessageBox.Show("Welcome" + " " + TextRegister.Text);
                LoadStorys LS = new LoadStorys();
                LS.ShowDialog();
            }
        }
    }
}
