using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Video_Game_Character_Quiz
{
    public partial class MediumQuiz : Form
    {
        StreamReader inputFile;

        string answer;

        public MediumQuiz()
        {
            InitializeComponent();
            inputFile = File.OpenText("medium.txt");
        }

/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private string updateQuestion()
        {
            answer = inputFile.ReadLine();

            return answer;
        }

        private void answer01_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;

           // pictureBox1.Visible = false;
           // pictureBox2.Visible = true;

            //totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer02_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

              answersGroup0.Visible = false;
              answersGroup1.Visible = true;

            //  pictureBox1.Visible = false;
             // pictureBox2.Visible = true;


            //totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer03_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

              answersGroup0.Visible = false;
              answersGroup1.Visible = true;

            //  pictureBox1.Visible = false;
             // pictureBox2.Visible = true;

            //totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    }
}
