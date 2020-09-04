using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormPictureGame : Form
    {
        private FacadePictureGame m_FacadePictureGame = LogicApp.sr_FacadePictureGame;
        public FormPictureGame()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {

            pictureBox1.LoadAsync(m_FacadePictureGame.m_PictureUrl);
            buttonAnswer1.Text = m_FacadePictureGame.m_Answers[0];
            buttonAnswer2.Text = m_FacadePictureGame.m_Answers[1];
            buttonAnswer3.Text = m_FacadePictureGame.m_Answers[2];
            buttonAnswer4.Text = m_FacadePictureGame.m_Answers[3];
            base.OnShown(e);
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(m_FacadePictureGame.EndGame(button.Text));
            this.Close();
        }
    }
}