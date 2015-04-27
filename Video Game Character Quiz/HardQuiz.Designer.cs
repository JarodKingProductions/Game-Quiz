namespace Video_Game_Character_Quiz
{
    partial class HardQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardQuiz));
            this.muffinButton = new System.Windows.Forms.Button();
            this.question1 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.answersGroup0 = new System.Windows.Forms.GroupBox();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.answersGroup0.SuspendLayout();
            this.SuspendLayout();
            // 
            // muffinButton
            // 
            this.muffinButton.Location = new System.Drawing.Point(12, 250);
            this.muffinButton.Name = "muffinButton";
            this.muffinButton.Size = new System.Drawing.Size(74, 30);
            this.muffinButton.TabIndex = 0;
            this.muffinButton.Text = "Exit";
            this.muffinButton.UseVisualStyleBackColor = true;
            this.muffinButton.Click += new System.EventHandler(this.muffinButton_Click);
            // 
            // question1
            // 
            this.question1.Location = new System.Drawing.Point(56, 18);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(236, 45);
            this.question1.TabIndex = 11;
            this.question1.Text = "Out of the three options, which career did Mario NOT have? ";
            this.question1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Question2
            // 
            this.Question2.Location = new System.Drawing.Point(56, 18);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(236, 45);
            this.Question2.TabIndex = 12;
            this.Question2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Question2.Visible = false;
            // 
            // answersGroup0
            // 
            this.answersGroup0.Controls.Add(this.button01);
            this.answersGroup0.Controls.Add(this.button02);
            this.answersGroup0.Controls.Add(this.button03);
            this.answersGroup0.Location = new System.Drawing.Point(12, 160);
            this.answersGroup0.Name = "answersGroup0";
            this.answersGroup0.Size = new System.Drawing.Size(345, 84);
            this.answersGroup0.TabIndex = 13;
            this.answersGroup0.TabStop = false;
            this.answersGroup0.Text = "Answers";
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(264, 19);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(75, 48);
            this.button01.TabIndex = 2;
            this.button01.Text = "Paddle spaceship master";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(136, 19);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(75, 48);
            this.button02.TabIndex = 1;
            this.button02.Text = "Candy Maker";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // button03
            // 
            this.button03.Location = new System.Drawing.Point(6, 19);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(75, 48);
            this.button03.TabIndex = 0;
            this.button03.Text = "Vietnam soldier";
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.button03_Click);
            // 
            // HardQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 292);
            this.Controls.Add(this.answersGroup0);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.question1);
            this.Controls.Add(this.muffinButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HardQuiz";
            this.Text = "Hard Quiz";
            this.answersGroup0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button muffinButton;
        private System.Windows.Forms.Label question1;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.GroupBox answersGroup0;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button03;
    }
}