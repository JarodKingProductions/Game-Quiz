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

        int totalScore = 0;

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

            pictureBox0.Visible = false;
            pictureBox1.Visible = true;

            totalScore += 1;
            Question2.Text = updateQuestion();
        }

        private void answer02_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;

            pictureBox0.Visible = false;
            pictureBox1.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer03_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;

            pictureBox0.Visible = false;
            pictureBox1.Visible = true;

            Question2.Text = updateQuestion();
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer11_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer12_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer13_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            totalScore += 1;
            Question2.Text = updateQuestion();
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void answer21_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer22_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            totalScore += 1;
            Question2.Text = updateQuestion();
        }

        private void answer23_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            Question2.Text = updateQuestion();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer31_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer32_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            totalScore += 1;
            Question2.Text = updateQuestion();
        }

        private void answer33_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            Question2.Text = updateQuestion();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer41_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

            totalScore += 1;
            Question2.Text = updateQuestion();
        }

        private void answer42_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

            totalScore += 1;
            Question2.Text = updateQuestion();
        }

        private void answer43_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

            totalScore += 1;
            Question2.Text = updateQuestion();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void muffinButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
