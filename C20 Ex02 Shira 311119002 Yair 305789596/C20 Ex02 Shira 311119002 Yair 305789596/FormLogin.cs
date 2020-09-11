using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormLogin : Form
    {
        public Func<LoginResult> LoginClick;
        public LoginResult LoginResult { get; set; }
        //public event Action LoginClick;


        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginResult = LoginClick.Invoke();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (this.checkBoxRememberMe.Checked)
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
