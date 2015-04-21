using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace Video_Game_Character_Quiz
{
    public partial class GameMenu : Form
    {

        private string _command;
        private bool isOpen;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hnwdCallBack);

        //button commands

        public GameMenu()
        {
            InitializeComponent();
        }

        private void gameMenu_Load(object sender, EventArgs e)
        {

        }

        private void easyQuiz_Click_1(object sender, EventArgs e)
        {
            EasyQuiz easyQuiz = new EasyQuiz();
            easyQuiz.ShowDialog();
        }

        private void instuctionsForm_Click(object sender, EventArgs e)
        {
            Instructions instructionsForm = new Instructions();
            instructionsForm.ShowDialog();
        }

        private void creditsForm_Click(object sender, EventArgs e)
        {
            Credits creditsForm = new Credits();
            creditsForm.ShowDialog();
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();
            ofd.Filter = "Mp3 files|*.Mp3|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = ofd.FileName.ToString();
            }
        }

            public void Play(bool loop)
        {
            if (isOpen)
            {
                _command = "play MediaFile";
                if (loop)
                    _command += "REPEAT";
                mciSendString(_command, null, 0, IntPtr.Zero);
            }
        }

        public void OpenPlayer(string sFileName)
        {
            _command = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        public void ClosePlayer()
        {
            _command = "close MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            try
            {
                this.OpenPlayer(this.textBox1.Text);
                this.Play(false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClosePlayer();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void muffinButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    
}

}





