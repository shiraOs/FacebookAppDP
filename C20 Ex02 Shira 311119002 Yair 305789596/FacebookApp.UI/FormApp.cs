using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormApp : Form
    {
        private readonly FormPictureGame r_PictureGameForm = new FormPictureGame();
        private readonly FormDetails r_FormDeatils = new FormDetails();
        private readonly FormLogin r_LoginForm = new FormLogin();
        private readonly AppSettings r_AppSettings;
        private readonly AdapterLoginFacebook r_LoginAdapter;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private string m_AccessToken;

        public FormApp()
        {
            InitializeComponent();
            this.Size = AppSettings.sr_SmallFormSize;
            r_AppSettings = AppSettings.LoadFromFile();
            r_LoginAdapter = new AdapterLoginFacebook(r_AppSettings);
            fetchSettingData();
        }

        private void buildFeaturesSetting()
        {
            DatingFeature.ResetFeature();
            FacadePictureGame.CreatePicturesGameFeature(m_LoggedInUser.Albums);
        }

        private void userLogin()
        {
            r_LoginForm.LoginClick += r_LoginAdapter.Login;
            DialogResult result = r_LoginForm.ShowDialog();
            m_LoginResult = r_LoginForm.LoginResult;
            checkFormLoginDialogResult(result);
        }

        private void checkFormLoginDialogResult(DialogResult i_Result)
        {
            if (i_Result != DialogResult.Cancel)
            {
                if (i_Result == DialogResult.Yes)
                {
                    this.checkBoxRememberMe.Checked = true;
                }
                else
                {
                    this.checkBoxRememberMe.Checked = false;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void logoutCompleted()
        {
            // FacebookWrapper.logout isn't working properly //
            MessageBox.Show("Logout Complete");
            this.Close();
        }

        private void fetchUserData()
        { // Using Threads
            fetchPersonalDetails();
            new Thread(fetchFriends).Start();
            new Thread(fetchAlbums).Start();
            new Thread(fetchPosts).Start();
        }

        private void fetchSettingData()
        {
            checkBoxRememberMe.Checked = r_AppSettings.RememberUser;
            m_AccessToken = r_AppSettings.LastAccessToken;
        }

        private void fetchPersonalDetails()
        { // Using data binding
            userBindingSource.DataSource = this.m_LoggedInUser;
            textBoxGender.Text = Utils.CheckPropertyStr(m_LoggedInUser.Gender.ToString());
        }

        private void fetchAlbums()
        { // Action in other threads and data binding
            listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = m_LoggedInUser.Albums));

            if (m_LoggedInUser.Albums.Count == 0)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("No Albums to Show.")));
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Enabled = false));
            }
        }

        private void fetchPosts()
        { // Action in other threads and data binding
            
            // listBoxPosts.Invoke(new Action(() => postBindingSource Filter = "Name LIKE ''"));;
            listBoxPosts.Invoke(new Action(() => postBindingSource.DataSource = m_LoggedInUser.WallPosts));
            
            if (m_LoggedInUser.WallPosts.Count == 0)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("No Posts to Show.")));
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Enabled = false));
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));

            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("No Friends to Show.")));
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Enabled = false));
            }
        }

        private void abortAlbumGame() /// DELETE
        { // Action in other threads
            labelSubAlbumGame.Invoke(new Action(() => labelSubAlbumGame.Text = "Cannot load Game!"));
            labelError.Invoke(new Action(() => labelError.Text = "You should have at least 4 albums with location"));
            labelGamePoints.Invoke(new Action(() => labelGamePoints.ForeColor = Color.White));
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox1.Invoke(new Action(() => pictureBox1.Enabled = false));
            pictureBox2.Invoke(new Action(() => pictureBox2.Enabled = false));
            pictureBox3.Invoke(new Action(() => pictureBox3.Enabled = false));
            pictureBox4.Invoke(new Action(() => pictureBox4.Enabled = false));
        }

        private void resetFeatures()
        {
            resetMatchFeature();
            resetPicturesGame();
            resetPostDetailes();
        }

        private void resetPicturesGame()
        {
            if(FacadePictureGame.IsFeatureAvailable)
            {
                FacadePictureGame.ResetFeature();
            }
        }

        private void resetPostDetailes()
        {
            textBoxPostMsg.Text = string.Empty;
            textBoxPostDate.Text = string.Empty;
            pictureBoxPost.Image = null;
            listBoxPosts.ClearSelected();
        }

        private void resetMatchFeature()
        {
            DatingFeature.ResetFeature();
            listBoxAgeRange.ClearSelected();
            listBoxMatchingFriends.Items.Clear();
            listBoxMatchingFriends.ClearSelected();
            checkBoxMale.Checked = false;
            checkBoxFemale.Checked = false;
        }

        private void showFriendForm(User i_SelectedFriend)
        {
            if (i_SelectedFriend != null)
            {
                r_FormDeatils.BuildForm(new IFormFriend(), i_SelectedFriend);
                r_FormDeatils.ShowDialog();
            }
        }

        private void setAlbumPictuersGame()
        {
            pictureBox1.LoadAsync(FacadePictureGame.FirstPictureURL);
            pictureBox2.LoadAsync(FacadePictureGame.SecondPictureURL);
            pictureBox3.LoadAsync(FacadePictureGame.ThirdPictureURL);
            pictureBox4.LoadAsync(FacadePictureGame.FourthPictureURL);
        }

        private void buttonOpenFeature_Click(object sender, EventArgs e)
        {
            if (!AppSettings.IsFeatureOpen(this.Size))
            {
                this.Size = AppSettings.sr_BigFormSize;
                buttonOpenFeature.Text = "Hide Features";
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 200);
            }
            else
            {
                this.Size = AppSettings.sr_SmallFormSize;
                buttonOpenFeature.Text = "Open Features";
                resetFeatures();
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 200);
            }
        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            listBoxMatchingFriends.Items.Clear();
            listBoxMatchingFriends.DisplayMember = "Name";
            listBoxMatchingFriends.Enabled = true;
            new Thread(searchForMatchingFriends).Start();
        }

        private void searchForMatchingFriends()
        {
            disableDatingFeatureButtons();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (DatingFeature.IsFriendMatchToUserRequests(friend))
                {
                    listBoxMatchingFriends.Invoke(new Action(() => listBoxMatchingFriends.Items.Add(friend)));
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }

            if (listBoxMatchingFriends.Items.Count == 0)
            {
                listBoxMatchingFriends.Invoke(new Action(() => listBoxMatchingFriends.Items.Add("No Matching Friends.")));
                listBoxMatchingFriends.Invoke(new Action(() => listBoxMatchingFriends.Enabled = false));
            }

            enableDatingFeatureButtons();
        }

        private void enableDatingFeatureButtons()
        {
            listBoxAgeRange.Invoke(new Action(() => listBoxAgeRange.Enabled = true));
            checkBoxMale.Invoke(new Action(() => checkBoxMale.Enabled = true));
            checkBoxFemale.Invoke(new Action(() => checkBoxFemale.Enabled = true));
        }

        private void disableDatingFeatureButtons()
        {
            listBoxAgeRange.Invoke(new Action(() => listBoxAgeRange.Enabled = false));
            buttonMatch.Invoke(new Action(() => buttonMatch.Enabled = false));
            checkBoxMale.Invoke(new Action(() => checkBoxMale.Enabled = false));
            checkBoxFemale.Invoke(new Action(() => checkBoxFemale.Enabled = false));
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(logoutCompleted);
        }

        private void listBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatingFeature.RequiredAgeRange = (DatingFeature.eAgeRange)listBoxAgeRange.SelectedIndex;
            if (checkBoxMale.Checked || checkBoxFemale.Checked)
            {
                buttonMatch.Enabled = true;
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        { // Invoke for both cases- match friends and all friends 
            ListBox listbox = sender as ListBox;
            showFriendForm(listbox.SelectedItem as User);
            listbox.ClearSelected();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItem != null)
            {
                showAlbumForm(listBoxAlbums.SelectedItem as Album);
            }

            listBoxAlbums.ClearSelected();
        }

        private void showAlbumForm(Album o_SelectedAlbum)
        {
            r_FormDeatils.BuildForm(new IFormAlbum(), o_SelectedAlbum);
            r_FormDeatils.ShowDialog();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Size.Equals(AppSettings.sr_BigFormSize))
            {                
                if (listBoxPosts.SelectedItem != null)
                {
                    // ProxyPost selectedPost = listBoxPosts.SelectedItem as ProxyPost;
                    // textBoxPostDate.Text = selectedPost.Date;
                    // textBoxPostMsg.Text = selectedPost.Message;
                    // pictureBoxPost.Image = selectedPost.PictureUrl;
                    string picturUrl = (listBoxPosts.SelectedItem as Post).PictureURL;
                    if (!string.IsNullOrEmpty(picturUrl))
                    {
                        pictureBoxPost.Load(picturUrl);
                    }
                }
            }
        }

        private void checkBoxGender_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currCheckBox = sender as CheckBox;
            string requiredGender = currCheckBox.Text;
            if (currCheckBox.Checked)
            {
                if (requiredGender.Equals("Male") && currCheckBox.Checked)
                {
                    DatingFeature.RequiredGender = User.eGender.male;
                    checkBoxFemale.Checked = false;
                }
                else if (requiredGender.Equals("Female") && currCheckBox.Checked)
                {
                    DatingFeature.RequiredGender = User.eGender.female;
                    checkBoxMale.Checked = false;
                }
                else
                {
                    buttonMatch.Enabled = false;
                }

                if (DatingFeature.RequiredAgeRange != null)
                {
                    buttonMatch.Enabled = true;
                }
            }
        }
        
        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            buttonLogout.Enabled = !checkBoxRememberMe.Checked;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            r_AppSettings.LastAccessToken = m_AccessToken;
            r_AppSettings.SaveToFile();
        }

        protected override void OnShown(EventArgs e)
        {
            m_LoginResult = r_LoginAdapter.Connect();
            
            if(m_LoginResult == null)
            {
                userLogin();
            }

            m_AccessToken = m_LoginResult.AccessToken;
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            fetchUserData();
            buildFeaturesSetting();
            base.OnShown(e);
        }

        private void replacePictureBoxGame()
        {
            switch (FacadePictureGame.PictureGameAlbumIndex)
            {
                case 0:
                    pictureBox1.LoadAsync(FacadePictureGame.FirstPictureURL);
                    break;
                case 1:
                    pictureBox2.LoadAsync(FacadePictureGame.SecondPictureURL);
                    break;
                case 2:
                    pictureBox3.LoadAsync(FacadePictureGame.ThirdPictureURL);
                    break;
                case 3:
                    pictureBox4.LoadAsync(FacadePictureGame.FourthPictureURL);
                    break;
            }
        }

        private void labelPics_Paint(object sender, PaintEventArgs e)
        {
            if(AppSettings.IsFeatureOpen(this.Size))
            {
                if(FacadePictureGame.IsFeatureAvailable)
                { // setting the game if user have more then 4 albums with pic and loction
                    setAlbumPictuersGame();
                }
                else
                {
                    abortAlbumGame();
                }
            }
        }

        private void pictureBoxGame_Click(object sender, EventArgs e)
        {
            FacadePictureGame.BuildGame(int.Parse((sender as PictureBox).Tag.ToString()));
            DialogResult res = r_PictureGameForm.ShowDialog();
            if(res == DialogResult.Yes)
            {
                FacadePictureGame.ReplaceRightAnswerPictureURL();
                replacePictureBoxGame();
            }

            labelGamePoints.Text = string.Format("You earn {0} points in game", FacadePictureGame.Points);
        }
    }
}