using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormFriend : Form
    {
        private User m_User;

        public FormFriend()
        {
            InitializeComponent();
        }

        public void BuildForm(User i_SelectedFriend)
        {
            //userBindingSource.DataSource = i_SelectedFriend;
            m_User = i_SelectedFriend;
            this.Text = m_User.Name;
            this.labelName.Text = i_SelectedFriend.Name;
            this.labelGender.Text = LogicApp.CheckPropertyStr(m_User.Gender.ToString());
            this.labelBirthday.Text = LogicApp.CheckPropertyStr(m_User.Birthday);
            this.labelCity.Text = LogicApp.CheckPropertyStr(m_User.Location.Name);
            LogicApp.LoadPicture(pictureBox1, m_User.PictureNormalURL);
        }
    }
}