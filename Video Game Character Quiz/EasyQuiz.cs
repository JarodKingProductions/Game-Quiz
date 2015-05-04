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
    //hi
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

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
                
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

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer03_Click(object sender, EventArgs e)
        {
            question1.Visible = false;
            Question2.Visible = true;

            answersGroup0.Visible = false;
            answersGroup1.Visible = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }
        //kirby
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer11_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer12_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void answer13_Click(object sender, EventArgs e)
        {
            answersGroup1.Visible = false;
            answersGroup2.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            Question2.Text = updateQuestion();
        }
        //mario
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer21_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void answer22_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;


            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer23_Click(object sender, EventArgs e)
        {
            answersGroup2.Visible = false;
            answersGroup3.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

            Question2.Text = updateQuestion();
        }
        //greg
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer31_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

            Question2.Text = updateQuestion();
        }



        private void answer32_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void answer33_Click(object sender, EventArgs e)
        {
            answersGroup3.Visible = false;
            answersGroup4.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;


            Question2.Text = updateQuestion();
        }
        //LofZ
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer41_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer42_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer43_Click(object sender, EventArgs e)
        {
            answersGroup4.Visible = false;
            answersGroup5.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            totalScore += 1;

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

            Question2.Text = updateQuestion();
        }

        private void answer52_Click(object sender, EventArgs e)
        {
            answersGroup5.Visible = false;
            answersGroup6.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer53_Click(object sender, EventArgs e)
        {
            answersGroup5.Visible = false;
            answersGroup6.Visible = true;

            pictureBox6.Visible = false;
            pictureBox7.Visible = true;

            Question2.Text = updateQuestion();
        }
       //yoshi
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer61_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = false;
            answersGroup7.Visible = true;

            pictureBox7.Visible = false;
            pictureBox8.Visible = true;


            Question2.Text = updateQuestion();
        }

        private void answer62_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = false;
            answersGroup7.Visible = true;

            pictureBox7.Visible = false;
            pictureBox8.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer63_Click(object sender, EventArgs e)
        {
            answersGroup6.Visible = false;
            answersGroup7.Visible = true;

            pictureBox7.Visible = false;
            pictureBox8.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer71_Click(object sender, EventArgs e)
        {
            answersGroup7.Visible = false;
            answersGroup8.Visible = true;

            pictureBox8.Visible = false;
            pictureBox9.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void answer72_Click(object sender, EventArgs e)
        {
            answersGroup7.Visible = false;
            answersGroup8.Visible = true;

            pictureBox8.Visible = false;
            pictureBox9.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer73_Click(object sender, EventArgs e)
        {
            answersGroup7.Visible = false;
            answersGroup8.Visible = true;

            pictureBox8.Visible = false;
            pictureBox9.Visible = true;

            Question2.Text = updateQuestion();
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void answer81_Click(object sender, EventArgs e)
        {
            answersGroup8.Visible = false;
            answersGroup9.Visible = true;

            pictureBox9.Visible = false;
            pictureBox10.Visible = true;

            Question2.Text = updateQuestion();
        }

        private void answer82_Click(object sender, EventArgs e)
        {
            answersGroup8.Visible = false;
            answersGroup9.Visible = true;

            pictureBox9.Visible = false;
            pictureBox10.Visible = true;

            totalScore += 1;

            Question2.Text = updateQuestion();
        }

        private void answer83_Click(object sender, EventArgs e)
        {
            answersGroup8.Visible = false;
            answersGroup9.Visible = true;

            pictureBox9.Visible = false;
            pictureBox10.Visible = true;

            Question2.Text = updateQuestion();
        }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

        private void answer91_Click(object sender, EventArgs e)
        {
            answersGroup9.Visible = false;
            finalScoreBox.Visible = true;

            pictureBox10.Visible = false;
            trophyPhoto.Visible = true;

            Question2.Text = updateQuestion();
             //
             if (finalScoreBox.Visible == true)
             {
                 finalScoreText.Text = totalScore.ToString("n1");
 
                 finalScoreText.Text = "You got " + totalScore + " out of 10.";
             }
        }

        private void answer92_Click(object sender, EventArgs e)
        {
            answersGroup9.Visible = false;
            finalScoreBox.Visible = true;

            pictureBox10.Visible = false;
            trophyPhoto.Visible = true;

            Question2.Text = updateQuestion();
             //
             if (finalScoreBox.Visible == true)
             {
                 finalScoreText.Text = totalScore.ToString("n1");
 
                 finalScoreText.Text = "You got " + totalScore + " out of 10.";
             }
        }

        private void answer93_Click(object sender, EventArgs e)
        {
            answersGroup9.Visible = false;
            finalScoreBox.Visible = true;

            pictureBox10.Visible = false;
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

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
