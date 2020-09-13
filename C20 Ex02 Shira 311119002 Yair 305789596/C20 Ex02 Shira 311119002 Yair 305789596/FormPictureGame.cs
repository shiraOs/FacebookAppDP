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
            pictureBox1.LoadAsync(FacadePictureGame.GamePictureUrl);
            buttonAnswer1.Text = FacadePictureGame.FirstAnswer;
            buttonAnswer2.Text = FacadePictureGame.SecondAnswer;
            buttonAnswer3.Text = FacadePictureGame.ThirdAnswer;
            buttonAnswer4.Text = FacadePictureGame.ForthAnswer;
            base.OnShown(e);
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            FacadePictureGame.UserAnswer = button.Text;
            MessageBox.Show(FacadePictureGame.AnswerMessageGame);
            if(FacadePictureGame.IsRightAnswer())
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
            this.Close();
        }
    }
}