using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryMachine.UserInterface
{
    public partial class WelcomeScreen : Form
    {
        private object openForm;

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterName EN = new EnterName(); 
            EN.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadStory1 NRF = new LoadStory1();
            NRF.ShowDialog();
           

        }
    }
}
