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
    public partial class EnterName : StoryScreen
    {
        internal static bool openForm;
        
        public EnterName()
        {
            InitializeComponent();
        }

        private void EnterName_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameText.Text))
            {



            }
        }


        private void Login_Button_Click(object sender, EventArgs e)
        {
            string name = NameText.Text;
            bool isSuccessful = playerHandler.Login(name);
            
            if (!isSuccessful)
            {
                MessageBox.Show("User with name " + name + " does not exist. Please register first.");
            } else
            {
                MessageBox.Show("Welcome back" + " " + name);
                LoadStorys LS = new LoadStorys();
                LS.ShowDialog();
            }
        }

       





    }
}
