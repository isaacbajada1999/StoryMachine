namespace StoryMachine.UserInterface
{
    partial class LoadStorys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadStorys));
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Story1Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.story2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.story3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.story4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.story5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.story6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.story7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.story8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.story9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.story10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 45);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.startToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem1});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.loadToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Story1Menu,
            this.story2ToolStripMenuItem,
            this.story3ToolStripMenuItem,
            this.story4ToolStripMenuItem,
            this.story5ToolStripMenuItem,
            this.story6ToolStripMenuItem,
            this.story7ToolStripMenuItem,
            this.story8ToolStripMenuItem,
            this.story9ToolStripMenuItem,
            this.story10ToolStripMenuItem});
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(324, 38);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(139, 38);
            this.startToolStripMenuItem.Text = "Last Saved";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(64, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 130);
            this.panel1.TabIndex = 3;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(165, 384);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(214, 49);
            this.button13.TabIndex = 4;
            this.button13.Text = "New Game";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(631, 384);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(214, 49);
            this.button14.TabIndex = 5;
            this.button14.Text = "Continue";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // LoadStorys
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1101, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "LoadStorys";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Story1Menu;
        private System.Windows.Forms.ToolStripMenuItem story2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem story3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem story4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem story5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem story6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem story7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem story8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem story9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem story10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    }
}