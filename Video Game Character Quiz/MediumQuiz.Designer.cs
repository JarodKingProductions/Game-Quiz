namespace Video_Game_Character_Quiz
{
    partial class MediumQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediumQuiz));
            this.answersGroup6 = new System.Windows.Forms.GroupBox();
            this.answer03 = new System.Windows.Forms.Button();
            this.answer02 = new System.Windows.Forms.Button();
            this.answer01 = new System.Windows.Forms.Button();
            this.muffinButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.answersGroup6.SuspendLayout();
            this.SuspendLayout();
            // 
            // answersGroup6
            // 
            this.answersGroup6.Controls.Add(this.answer03);
            this.answersGroup6.Controls.Add(this.answer02);
            this.answersGroup6.Controls.Add(this.answer01);
            this.answersGroup6.Location = new System.Drawing.Point(12, 159);
            this.answersGroup6.Name = "answersGroup6";
            this.answersGroup6.Size = new System.Drawing.Size(345, 84);
            this.answersGroup6.TabIndex = 4;
            this.answersGroup6.TabStop = false;
            this.answersGroup6.Text = "Answers";
            this.answersGroup6.Visible = false;
            // 
            // answer03
            // 
            this.answer03.Location = new System.Drawing.Point(264, 19);
            this.answer03.Name = "answer03";
            this.answer03.Size = new System.Drawing.Size(75, 48);
            this.answer03.TabIndex = 2;
            this.answer03.Text = "Duplex roll";
            this.answer03.UseVisualStyleBackColor = true;
            // 
            // answer02
            // 
            this.answer02.Location = new System.Drawing.Point(136, 19);
            this.answer02.Name = "answer02";
            this.answer02.Size = new System.Drawing.Size(75, 48);
            this.answer02.TabIndex = 1;
            this.answer02.Text = "Barrel roll";
            this.answer02.UseVisualStyleBackColor = true;
            this.answer02.Visible = false;
            // 
            // answer01
            // 
            this.answer01.Location = new System.Drawing.Point(6, 19);
            this.answer01.Name = "answer01";
            this.answer01.Size = new System.Drawing.Size(75, 48);
            this.answer01.TabIndex = 0;
            this.answer01.Text = "Aileron Roll";
            this.answer01.UseVisualStyleBackColor = true;
            // 
            // muffinButton
            // 
            this.muffinButton.Location = new System.Drawing.Point(13, 250);
            this.muffinButton.Name = "muffinButton";
            this.muffinButton.Size = new System.Drawing.Size(75, 30);
            this.muffinButton.TabIndex = 5;
            this.muffinButton.Text = "Exit";
            this.muffinButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // MediumQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muffinButton);
            this.Controls.Add(this.answersGroup6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediumQuiz";
            this.Text = "Medium Quiz";
            this.answersGroup6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox answersGroup6;
        private System.Windows.Forms.Button answer03;
        private System.Windows.Forms.Button answer02;
        private System.Windows.Forms.Button answer01;
        private System.Windows.Forms.Button muffinButton;
        private System.Windows.Forms.Label label1;
    }
}