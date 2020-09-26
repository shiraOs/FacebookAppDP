using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public partial class FormLogin : Form
    {
        public Func<string, string[], LoginResult> LoginClick;

        public LoginResult LoginResult { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult = LoginClick.Invoke(AppSettings.sr_AppID, AppSettings.sr_Permissions);

            if (string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                MessageBox.Show(LoginResult.ErrorMessage);
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
