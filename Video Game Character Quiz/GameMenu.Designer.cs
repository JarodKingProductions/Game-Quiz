namespace Video_Game_Character_Quiz
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.menuBack = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.muffinButton = new System.Windows.Forms.Button();
            this.instuctionsForm = new System.Windows.Forms.Button();
            this.creditsForm = new System.Windows.Forms.Button();
            this.easyQuiz = new System.Windows.Forms.Button();
            this.linc_HiddenButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuBack)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBack
            // 
            this.menuBack.Image = ((System.Drawing.Image)(resources.GetObject("menuBack.Image")));
            this.menuBack.Location = new System.Drawing.Point(39, 58);
            this.menuBack.Name = "menuBack";
            this.menuBack.Size = new System.Drawing.Size(290, 164);
            this.menuBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBack.TabIndex = 0;
            this.menuBack.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 228);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 20);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(12, 254);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 20);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 4;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(282, 228);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 46);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse MP3";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // muffinButton
            // 
            this.muffinButton.Location = new System.Drawing.Point(143, 268);
            this.muffinButton.Name = "muffinButton";
            this.muffinButton.Size = new System.Drawing.Size(75, 23);
            this.muffinButton.TabIndex = 7;
            this.muffinButton.Text = "Exit";
            this.muffinButton.UseVisualStyleBackColor = true;
            this.muffinButton.Click += new System.EventHandler(this.muffinButton_Click);
            // 
            // instuctionsForm
            // 
            this.instuctionsForm.Location = new System.Drawing.Point(12, 58);
            this.instuctionsForm.Name = "instuctionsForm";
            this.instuctionsForm.Size = new System.Drawing.Size(75, 164);
            this.instuctionsForm.TabIndex = 8;
            this.instuctionsForm.Text = "Instructions";
            this.instuctionsForm.UseVisualStyleBackColor = true;
            this.instuctionsForm.Click += new System.EventHandler(this.instuctionsForm_Click);
            // 
            // creditsForm
            // 
            this.creditsForm.Location = new System.Drawing.Point(282, 58);
            this.creditsForm.Name = "creditsForm";
            this.creditsForm.Size = new System.Drawing.Size(75, 164);
            this.creditsForm.TabIndex = 9;
            this.creditsForm.Text = "Credits";
            this.creditsForm.UseVisualStyleBackColor = true;
            this.creditsForm.Click += new System.EventHandler(this.creditsForm_Click);
            // 
            // easyQuiz
            // 
            this.easyQuiz.Location = new System.Drawing.Point(12, 12);
            this.easyQuiz.Name = "easyQuiz";
            this.easyQuiz.Size = new System.Drawing.Size(75, 40);
            this.easyQuiz.TabIndex = 10;
            this.easyQuiz.Text = "Easy Quiz";
            this.easyQuiz.UseVisualStyleBackColor = true;
            this.easyQuiz.Click += new System.EventHandler(this.easyQuiz_Click_1);
            // 
            // linc_HiddenButton
            // 
            this.linc_HiddenButton.Location = new System.Drawing.Point(143, 12);
            this.linc_HiddenButton.Name = "linc_HiddenButton";
            this.linc_HiddenButton.Size = new System.Drawing.Size(75, 40);
            this.linc_HiddenButton.TabIndex = 11;
            this.linc_HiddenButton.Text = "Medium";
            this.linc_HiddenButton.UseVisualStyleBackColor = true;
            this.linc_HiddenButton.Click += new System.EventHandler(this.linc_HiddenButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Hard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.HardQuiz);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(369, 292);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linc_HiddenButton);
            this.Controls.Add(this.easyQuiz);
            this.Controls.Add(this.creditsForm);
            this.Controls.Add(this.instuctionsForm);
            this.Controls.Add(this.muffinButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.menuBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameMenu";
            this.Text = "Video Game Character Quiz";
            this.Load += new System.EventHandler(this.gameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox menuBack;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button muffinButton;
        private System.Windows.Forms.Button instuctionsForm;
        private System.Windows.Forms.Button creditsForm;
        private System.Windows.Forms.Button easyQuiz;
        private System.Windows.Forms.Button linc_HiddenButton;
        private System.Windows.Forms.Button button3;
    }
}