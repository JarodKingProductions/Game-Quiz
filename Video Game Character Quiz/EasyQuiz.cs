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
    
    public partial class EasyQuiz : Form
    {
        StreamReader inputFile;

        string answer;

        public EasyQuiz()
        {
            InitializeComponent();
            inputFile = File.OpenText("EZ_questions.txt");
        }

        int totalScore = 0;
       //pokemon
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void answer01_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;
            answersGroup2.Visible = false;
            answersGroup3.Visible = false;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();
                
            Question2.Text = updateQuestion();
            
        }

        private string updateQuestion()
        {
            answer = inputFile.ReadLine();

            return answer;
        }

        private void answer02_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;
            answersGroup2.Visible = false;
            answersGroup3.Visible = false;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer03_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;
            answersGroup2.Visible = false;
            answersGroup3.Visible = false;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScore += 1;
            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }
        //kirby
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer11_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;
            answersGroup3.Visible = false;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer12_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;
            answersGroup3.Visible = false;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScore += 1;
            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer13_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;
            answersGroup3.Visible = false;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }
        //mario
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer21_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScore += 1;
            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer22_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer23_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;
            answersGroup4.Visible = false;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }
        //greg
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer31_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = false;
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }



        private void answer32_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = false;
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScore += 1;
            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer33_Click(object sender, EventArgs e)
        {
            answersGroup0.Visible = false;
            answersGroup1.Visible = false;
            answersGroup2.Visible = false;
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;
            answersGroup5.Visible = false;
            answersGroup6.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }
        //LofZ
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer41_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup6.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer42_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup6.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer43_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup6.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            totalScore += 1;
            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }
        //sam
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer51_Click(object sender, EventArgs e)
        {
            answersGroup5.Visible = false;
            answersGroup6.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = true;

            totalScore += 1;
            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer52_Click(object sender, EventArgs e)
        {
            answersGroup5.Visible = false;
            answersGroup6.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = true;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer53_Click(object sender, EventArgs e)
        {
            answersGroup5.Visible = false;
            answersGroup6.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = true;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }
       //yoshi
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer61_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = false;

            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer62_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = true;

            pictureBox7.Visible = false;

            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

        private void answer63_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = true;

            pictureBox7.Visible = false;

            totalScore += 1;
            totalScoreLabel.Text = totalScore.ToString();

            Question2.Text = updateQuestion();
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void answer31_MouseEnter(object sender, System.EventArgs e)
        {
            Greg.Visible = true;
        }

        private void answer31_MouseLeave(object sender, System.EventArgs e)
        {
            Greg.Visible = false;
        }

        //
        //

        private void totalScoreLabel_Click(object sender, EventArgs e)
        {
            totalScoreLabel.Text = totalScore.ToString();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
