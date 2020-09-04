using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormApp : Form
    {
        public event Action PictureClick;

        private readonly FormPictureGame r_PictureGameForm = new FormPictureGame();
        private readonly FormLogin r_LoginForm = new FormLogin();
        private readonly FormFriend r_FriendForm = new FormFriend();
        private readonly FormAlbum r_AlbumForm = new FormAlbum();
        private readonly AppSettings r_AppSettings;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private string m_AccessToken;

        public FormApp()
        {
            InitializeComponent();
            this.Size = LogicApp.sr_SmallFormSize;
            buildFeaturesSetting();
            r_AppSettings = AppSettings.LoadFromFile();
            fetchSettingData();
        }
        

        private void buildFeaturesSetting()
        {
            PictureClick += LogicApp.CreateFacadePictureGame;
            PictureClick += OnPictureClicked;
            LogicApp.sr_FacadePictureGame.RightAnswerClicked += OnGamePictureRightAnswer;
            LogicApp.RequiredAgeRange = LogicApp.eAgeRange.eNoChoice;
        }

        private void login()
        {
            r_LoginForm.LoginClick += loginAndLoad;
            DialogResult result = r_LoginForm.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                if (result == DialogResult.Yes)
                {
                    this.checkBoxRememberMe.Checked = true;
                }
                else
                {
                    this.checkBoxRememberMe.Checked = false;
                }

                fetchUserData();
            }
            else
            {
                this.Close();
            }
        }

        private void loginAndLoad()
        {
            LoginResult result = FacebookService.Login(LogicApp.sr_AppID, LogicApp.sr_Permissions);

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_AccessToken = result.AccessToken;
                m_LoggedInUser = result.LoggedInUser;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void loadPictureBox(string i_UrlPicture)
        {
            switch (LogicApp.PictureGameIndex)
            {
                case 0:
                    pictureBox1.LoadAsync(i_UrlPicture);
                    break;
                case 1:
                    pictureBox2.LoadAsync(i_UrlPicture);
                    break;
                case 2:
                    pictureBox3.LoadAsync(i_UrlPicture);
                    break;
                case 3:
                    pictureBox4.LoadAsync(i_UrlPicture);
                    break;
            }
        }

        private void logoutCompleted()
        {
            //FacebookWrapper.logout isn't working properly //
            MessageBox.Show("Logout Complete");
            this.Close();
        }

        private void fetchUserData()
        {
            fetchPersonalDetails();
            fetchFriends();
            fetchAlbums();
            fetchPosts();
        }

        private void fetchSettingData()
        {
            checkBoxRememberMe.Checked = r_AppSettings.RememberUser;
            m_AccessToken = r_AppSettings.LastAccessToken;
        }

        private void fetchPersonalDetails()
        {
            userBindingSource.DataSource = this.m_LoggedInUser;
            textBoxGender.Text = LogicApp.CheckPropertyStr(m_LoggedInUser.Gender.ToString());
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);

                if (!string.IsNullOrEmpty(album.Location) && !string.IsNullOrEmpty(album.PictureAlbumURL))
                { // album has picture and location
                    LogicApp.sr_AlbumGame.Add(album);
                    LogicApp.sr_AlbumsLocations.Add(album.Location);
                }
            }

            if (m_LoggedInUser.Albums.Count == 0)
            {
                listBoxAlbums.Items.Add("No Albums to Show.");
                listBoxAlbums.Enabled = false;
            }

            createAlbumGame();
        }

        private void fetchPosts()
        {
            listBoxPosts.DisplayMember = "Name";

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (!string.IsNullOrEmpty(post.Name))
                {
                    listBoxPosts.Items.Add(new ProxyPost(post));
                }
            }

            if (m_LoggedInUser.Posts.Count == 0)
            {
                listBoxPosts.Items.Add("No Posts to Show.");
                listBoxPosts.Enabled = false;
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                listBoxFriends.Items.Add("No Friends to Show.");
                listBoxFriends.Enabled = false;
            }
        }

        private void createAlbumGame()
        {
            // setting the game if user have more then 4 albums with pic and loction
            if (LogicApp.sr_AlbumsLocations.Count >= LogicApp.sr_NumOfAlbumsInGame)
            {
                setAlbumPictuersGame();
            }
            else
            {
                abortAlbumGame();
            }
        }

        private void abortAlbumGame()
        {
            labelSubAlbumGame.Text = "Cannot load Game!";
            labelError.Text = "You should have at least 4 album with location";
            labelGamePoints.ForeColor = Color.White;
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
        }

        private void resetFeatures()
        {
            resetMatchFeature();
            resetPostDetailes();
            LogicApp.sr_FacadePictureGame.Points = 0;
            labelGamePoints.Text = string.Format("You earn {0} points in game", LogicApp.sr_FacadePictureGame.Points);
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
            listBoxAgeRange.ClearSelected();
            listBoxMatchingFriends.Items.Clear();
            listBoxMatchingFriends.ClearSelected();
            checkBoxMale.Checked = false;
            checkBoxFemale.Checked = false;
        }

        private void showAlbumForm(int i_SelectedAlbumIndex)
        {
            if (i_SelectedAlbumIndex >= 0)
            {
                Album selectedAlbum = this.m_LoggedInUser.Albums[i_SelectedAlbumIndex];
                r_AlbumForm.BuildForm(selectedAlbum);
                r_AlbumForm.ShowDialog();
            }
        }

        private void showFriendForm(User i_SelectedFriend)
        {
            if (i_SelectedFriend != null)
            {
                r_FriendForm.BuildForm(i_SelectedFriend);
                r_FriendForm.ShowDialog();
            }
        }

        private void setAlbumPictuersGame()
        {
            LogicApp.ChooseRandomAlbums(out string url1, out string url2, out string url3, out string url4);
            pictureBox1.LoadAsync(url1);
            pictureBox2.LoadAsync(url2);
            pictureBox3.LoadAsync(url3);
            pictureBox4.LoadAsync(url4);
        }

        private void buttonOpenFeature_Click(object sender, EventArgs e)
        {
            if (!LogicApp.IsFeatureOpen(this.Size))
            {
                this.Size = LogicApp.sr_BigFormSize;
                buttonOpenFeature.Text = "Hide Features";
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 200);
            }
            else
            {
                this.Size = LogicApp.sr_SmallFormSize;
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

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (LogicApp.IsFriendMatchToUserRequests(friend))
                {
                    listBoxMatchingFriends.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }

            if (listBoxMatchingFriends.Items.Count == 0)
            {
                listBoxMatchingFriends.Items.Add("No Matching Friends.");
                listBoxMatchingFriends.Enabled = false;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            LogicApp.PictureGameIndex = int.Parse((sender as PictureBox).Tag.ToString());
            PictureClick.Invoke();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(logoutCompleted);
        }

        private void listBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogicApp.RequiredAgeRange = (LogicApp.eAgeRange)(sender as ListBox).SelectedIndex;
            if (checkBoxMale.Checked || checkBoxFemale.Checked)
            {
                buttonMatch.Enabled = true;
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        { // Invoke for both cases- match friends and all friends
            ListBox listbox = (sender as ListBox);
            showFriendForm((User)listbox.SelectedItem);
            listbox.ClearSelected();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAlbumForm(listBoxAlbums.SelectedIndex);
            listBoxAlbums.ClearSelected();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Size.Equals(LogicApp.sr_BigFormSize))
            {                
                if (listBoxPosts.SelectedItem != null)
                {
                    ProxyPost selectedPost =(ProxyPost)listBoxPosts.SelectedItem;
                    textBoxPostDate.Text = selectedPost.Date;
                    textBoxPostMsg.Text = selectedPost.Message;
                    LogicApp.LoadPicture(pictureBoxPost, selectedPost.PictureUrl);
                }

            }
        }

        private void checkBoxGender_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currCheckBox = sender as CheckBox;

            if (currCheckBox.Checked)
            {
                if (currCheckBox.Text.Equals("Male"))
                {
                    checkBoxFemale.Checked = false;
                    LogicApp.RequiredGender = User.eGender.male;
                }
                else
                {
                    checkBoxMale.Checked = false;
                    LogicApp.RequiredGender = User.eGender.female;
                }

                if (LogicApp.RequiredAgeRange != LogicApp.eAgeRange.eNoChoice)
                {
                    buttonMatch.Enabled = true;
                }
            }
            else
            {
                buttonMatch.Enabled = false;
            }
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRememberMe.Checked)
            {
                buttonLogout.Enabled = false;
            }
            else
            {
                buttonLogout.Enabled = true;
            }
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
            if (r_AppSettings.RememberUser
                && !string.IsNullOrEmpty(m_AccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AccessToken);
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            
                fetchUserData();
            }
            else
            {
                login();
            }

            base.OnShown(e);
        }

        private void OnPictureClicked()
        {
            r_PictureGameForm.ShowDialog();
        }

        private void OnGamePictureRightAnswer()
        {
            labelGamePoints.Text = string.Format("You earn {0} points in game", LogicApp.sr_FacadePictureGame.Points);
            LogicApp.ReplaceAlbumIndex();
            loadPictureBox(LogicApp.GetNewPictureUrl());
        }
    }
}