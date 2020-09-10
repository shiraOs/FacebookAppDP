using System;
using System.Windows.Forms;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormPictureGame : Form
    {
        public FormPictureGame()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            pictureBox1.LoadAsync(FacadePictureGame.PictureUrl);
            buttonAnswer1.Text = FacadePictureGame.AnswerOne;
            buttonAnswer2.Text = FacadePictureGame.AnswerTwo;
            buttonAnswer3.Text = FacadePictureGame.AnswerThree;
            buttonAnswer4.Text = FacadePictureGame.AnswerFour;
            base.OnShown(e);
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            FacadePictureGame.UserAnswer = button.Text;
            MessageBox.Show(FacadePictureGame.AnswerMessageGame);
            this.Close();
        }
    }
}