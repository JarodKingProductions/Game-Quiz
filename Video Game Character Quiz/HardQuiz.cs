﻿using System;
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
    public partial class HardQuiz : Form
    {
        StreamReader inputFile;

        string answer;
        public HardQuiz()
        {
            InitializeComponent();
            inputFile = File.OpenText("Hard.txt");
        }

        int totalScore = 0;

        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        private string updateQuestion()
        {
            answer = inputFile.ReadLine();

            return answer;
        }
        private void muffinButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button03_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;

            pictureBox0.Visible = false;
            pictureBox1.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button02_Click(object sender, EventArgs e)
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

        private void button01_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;

            pictureBox0.Visible = false;
            pictureBox1.Visible = true;

            Question2.Text = updateQuestion();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button13_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            Question2.Text = updateQuestion();
        }
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button23_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            Question2.Text = updateQuestion();
        }
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button33_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button43_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

            Question2.Text = updateQuestion();
        }
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button53_Click(object sender, EventArgs e)
        {
            answersGroup5.Visible = false;
            answersGroup6.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            answersGroup5.Visible = false;
            answersGroup6.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            answersGroup5.Visible = false;
            answersGroup6.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button62_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = false;
            answersGroup7.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = false;
            answersGroup7.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = false;
            answersGroup7.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = true;

            Question2.Text = updateQuestion();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button73_Click(object sender, EventArgs e)
        {
            answersGroup7.Visible = false;
            answersGroup8.Visible = true;

            pictureBox7.Visible = false;
            pictureBox8.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            answersGroup7.Visible = false;
            answersGroup8.Visible = true;

            pictureBox7.Visible = false;
            pictureBox8.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            answersGroup7.Visible = false;
            answersGroup8.Visible = true;

            pictureBox7.Visible = false;
            pictureBox8.Visible = true;

            Question2.Text = updateQuestion();
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void answer81_Click(object sender, EventArgs e)
        {
            answersGroup8.Visible = false;
            answersGroup9.Visible = true;

            pictureBox8.Visible = false;
            pictureBox9.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer82_Click(object sender, EventArgs e)
        {
            answersGroup8.Visible = false;
            answersGroup9.Visible = true;

            pictureBox8.Visible = false;
            pictureBox9.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void answer83_Click(object sender, EventArgs e)
        {
            answersGroup8.Visible = false;
            answersGroup9.Visible = true;

            pictureBox8.Visible = false;
            pictureBox9.Visible = true;

            Question2.Text = updateQuestion();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button93_Click(object sender, EventArgs e)
        {
            answersGroup9.Visible = false;
            finalScoreBox.Visible = true;

            pictureBox9.Visible = false;
            trophyPhoto.Visible = true;

            Question2.Text = updateQuestion();
            //
            if (finalScoreBox.Visible == true)
            {
                finalScoreText.Text = totalScore.ToString("n1");

                finalScoreText.Text = "You got " + totalScore + " out of 10.";
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            answersGroup9.Visible = false;
            finalScoreBox.Visible = true;

            pictureBox9.Visible = false;
            trophyPhoto.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
            //
            if (finalScoreBox.Visible == true)
            {
                finalScoreText.Text = totalScore.ToString("n1");

                finalScoreText.Text = "You got " + totalScore + " out of 10.";
            }
        }
        private void button91_Click(object sender, EventArgs e)
        {
            answersGroup9.Visible = false;
            finalScoreBox.Visible = true;

            pictureBox9.Visible = false;
            trophyPhoto.Visible = true;

            Question2.Text = updateQuestion();
            //
            if (finalScoreBox.Visible == true)
            {
                finalScoreText.Text = totalScore.ToString("n1");

                finalScoreText.Text = "You got " + totalScore + " out of 10.";
            }
        }

        private void HardQuiz_Load(object sender, EventArgs e)
        {

        }

        private void finalScoreText_Click(object sender, EventArgs e)
        {

        }








        /// /////////////////////////////////////////////////

    }
}
