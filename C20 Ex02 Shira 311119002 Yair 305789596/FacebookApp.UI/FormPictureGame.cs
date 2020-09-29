using System;
using System.Windows.Forms;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public partial class FormPictureGame : Form
    {
        public FormPictureGame()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        { // DATA BINDING INSTEAD CODE 
            labelAlbumName.Text = VMPictureGame.AlbumName;
            labelQuestion.Text = VMPictureGame.QuestionGame;
            pictureBox1.LoadAsync(VMPictureGame.GamePictureUrl);
            buttonAnswer1.Text = VMPictureGame.FirstAnswer;
            buttonAnswer2.Text = VMPictureGame.SecondAnswer;
            buttonAnswer3.Text = VMPictureGame.ThirdAnswer;
            buttonAnswer4.Text = VMPictureGame.ForthAnswer;
            base.OnShown(e);
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            VMPictureGame.UserAnswer = button.Text;
            MessageBox.Show(VMPictureGame.AnswerMessageGame);
            if(VMPictureGame.IsRightAnswer())
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