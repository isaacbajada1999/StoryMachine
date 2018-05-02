namespace StoryMachine.UserInterface
{
    partial class StoryFormStart
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passageTextBox = new System.Windows.Forms.GroupBox();
            this.option1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.SaveGame,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1674, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveGame
            // 
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(77, 36);
            this.SaveGame.Text = "Save";
            this.SaveGame.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(75, 36);
            this.newToolStripMenuItem.Text = "New";
            // 
            // passageTextBox
            // 
            this.passageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passageTextBox.Location = new System.Drawing.Point(217, 69);
            this.passageTextBox.Name = "passageTextBox";
            this.passageTextBox.Size = new System.Drawing.Size(1218, 494);
            this.passageTextBox.TabIndex = 1;
            this.passageTextBox.TabStop = false;
            this.passageTextBox.Enter += new System.EventHandler(this.passageTextBox_Enter);
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(205, 589);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(575, 88);
            this.option1.TabIndex = 2;
            this.option1.Text = "Option 1";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(786, 702);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(649, 99);
            this.button3.TabIndex = 4;
            this.button3.Text = "Option 4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(786, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(649, 88);
            this.button4.TabIndex = 5;
            this.button4.Text = "Option 3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(205, 702);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(575, 99);
            this.button5.TabIndex = 6;
            this.button5.Text = "Option 2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // StoryFormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1674, 850);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.passageTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StoryFormStart";
            this.Text = "StoryFormStart";
            this.Load += new System.EventHandler(this.StoryFormStart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveGame;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox passageTextBox;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}