namespace StoryMachine.UserInterface
{
    partial class LoadStory1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadStory1));
            this.label1 = new System.Windows.Forms.Label();
            this.TextRegister = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // TextRegister
            // 
            this.TextRegister.Location = new System.Drawing.Point(339, 225);
            this.TextRegister.Name = "TextRegister";
            this.TextRegister.Size = new System.Drawing.Size(266, 31);
            this.TextRegister.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 187);
            this.panel1.TabIndex = 3;
            // 
            // LoadStory1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(904, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextRegister);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "LoadStory1";
            this.Text = "NameRegisterform";
            this.Load += new System.EventHandler(this.LoadStory1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}