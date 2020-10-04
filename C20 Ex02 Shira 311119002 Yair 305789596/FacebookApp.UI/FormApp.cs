using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public partial class FormApp : Form
    {
        private readonly FormPictureGame r_PictureGameForm = new FormPictureGame();
        private readonly FormDetails r_FormDeatils = new FormDetails();
        private readonly FormLogin r_LoginForm = new FormLogin();
        private readonly AppSettings r_AppSettings;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private string m_AccessToken;


        public FormApp()
        {
            InitializeComponent();
            this.Size = AppSettings.sr_SmallFormSize;
            r_AppSettings = AppSettings.LoadFromFile();
            initPictureBox();
            fetchSettingData();
        }

        private void initPictureBox()
        {
            pictureBox1.LoadAsync(Utils.s_DefaultPictureUrl);
            pictureBox2.LoadAsync(Utils.s_DefaultPictureUrl);
            pictureBox3.LoadAsync(Utils.s_DefaultPictureUrl);
            pictureBox4.LoadAsync(Utils.s_DefaultPictureUrl);
        }

        private void buildFeaturesSetting()
        {
            DatingFeature.RestartFeature();
        }

        private void userLogin()
        {
            r_LoginForm.LoginClick += FacebookService.Login;
            DialogResult result = r_LoginForm.ShowDialog();
            m_LoginResult = r_LoginForm.LoginResult;
            checkFormLoginDialogResult(result);
        }

        private void checkFormLoginDialogResult(DialogResult i_Result)
        {
            if (i_Result != DialogResult.Cancel)
            {
                this.checkBoxRememberMe.Checked = i_Result == DialogResult.Yes ? true : false;
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
          // About detail not available but you can change the field
          // Gender is not option in data binding for User
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
            listBoxPosts.Invoke(new Action(() => listBoxPosts.DisplayMember = "Name"));

            foreach (Post post in m_LoggedInUser.NewsFeed)
            {
                if (!string.IsNullOrEmpty(post.Name) && listBoxPosts.IsHandleCreated)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(new AdapterPost { Adoptee = post })));
                }
            }

            if (m_LoggedInUser.NewsFeed.Count == 0)
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

        private void abortAlbumGame()
        { // Action in other threads
          // If user doesn't have at least 4 albums with location and picture
            bool pictureBoxState = false;
            labelSubAlbumGame.Invoke(new Action(() => labelSubAlbumGame.Text = "Cannot load Game!"));
            labelError.Invoke(new Action(() => labelError.Text = "You should have at least 4 albums with location"));
            labelGamePoints.Invoke(new Action(() => labelGamePoints.ForeColor = Color.White));
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            setPictureBoxsState(pictureBoxState);
        }

        private void setPictureBoxsState(bool pictureBoxState)
        {
            pictureBox1.Invoke(new Action(() => pictureBox1.Enabled = pictureBoxState));
            pictureBox2.Invoke(new Action(() => pictureBox2.Enabled = pictureBoxState));
            pictureBox3.Invoke(new Action(() => pictureBox3.Enabled = pictureBoxState));
            pictureBox4.Invoke(new Action(() => pictureBox4.Enabled = pictureBoxState));
        }

        private void resetFeatures()
        {
            resetMatchFeature();
            resetPicturesGame();
            resetPostDetailes();
        }

        private void resetPicturesGame()
        {
            if (VMGameBoard.IsFeatureAvailable)
            {
                bool state = false;
                VMGameBoard.ResetFeature();
                initPictureBox();
                setPictureBoxsState(state);
                updatePointsLable();
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
            DatingFeature.RestartFeature();
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
            labelSubAlbumGame.Invoke(new Action(() => labelSubAlbumGame.Text = "Press the picture to play"));
            labelError.Invoke(new Action(() => labelError.Text = ""));
            labelGamePoints.Invoke(new Action(() => labelGamePoints.ForeColor = Color.Black));
            pictureBox1.LoadAsync(VMGameBoard.GetPicUrlByIndex(0));
            pictureBox2.LoadAsync(VMGameBoard.GetPicUrlByIndex(1));
            pictureBox3.LoadAsync(VMGameBoard.GetPicUrlByIndex(2));
            pictureBox4.LoadAsync(VMGameBoard.GetPicUrlByIndex(3));
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
            bool state = false;
            setStateDatingFeatureButtons(state);
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
            setStateDatingFeatureButtons(!state);
        }


        private void setStateDatingFeatureButtons(bool i_State)
        {
            listBoxAgeRange.Invoke(new Action(() => listBoxAgeRange.Enabled = i_State));
            checkBoxMale.Invoke(new Action(() => checkBoxMale.Enabled = i_State));
            checkBoxFemale.Invoke(new Action(() => checkBoxFemale.Enabled = i_State));
            if (i_State == false)
            {
                buttonMatch.Invoke(new Action(() => buttonMatch.Enabled = i_State));
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(logoutCompleted);
        }

        private void listBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatingFeature.eAgeRange? ageRange;
            if (DatingFeature.RequiredAgeRange != (DatingFeature.eAgeRange)listBoxAgeRange.SelectedIndex)
            {
                ageRange = (DatingFeature.eAgeRange)listBoxAgeRange.SelectedIndex;
            }
            else
            {
                ageRange = null;
                listBoxAgeRange.ClearSelected();
   
            }
            DatingFeature.RequiredAgeRange = ageRange;
            setButtonMatchState();
        }

        private void setButtonMatchState()
        {
            if (DatingFeature.RequiredAgeRange != null || DatingFeature.RequiredGender != null)
            {
                buttonMatch.Enabled = true;
            }
            else
            {
                buttonMatch.Enabled = false;
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

        private void showAlbumForm(Album i_SelectedAlbum)
        {
            if(i_SelectedAlbum != null)
            {
                r_FormDeatils.BuildForm(new IFormAlbum(), i_SelectedAlbum);
                r_FormDeatils.ShowDialog();
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Size.Equals(AppSettings.sr_BigFormSize))
            {                
                if (listBoxPosts.SelectedItem != null)
                {
                    AdapterPost selectedPost = listBoxPosts.SelectedItem as AdapterPost;
                    textBoxPostDate.Text = Convert.ToDateTime(selectedPost.CreatedTime).ToShortDateString();
                    textBoxPostMsg.Text = selectedPost.Description;
                    pictureBoxPost.LoadAsync(selectedPost.PictureURL);
                }
            }
        }

        private void checkBoxGender_CheckedChanged(object sender, EventArgs e)
        { 
            CheckBox currCheckBox = sender as CheckBox;
            string requiredGender = currCheckBox.Text;

            if (currCheckBox.Checked)
            {
                DatingFeature.RequiredGender = DatingFeature.ParseGender(requiredGender);
                checkBoxFemale.Checked = requiredGender.Equals("Female");
                checkBoxMale.Checked = requiredGender.Equals("Male");
            }
            else
            {
                if (checkBoxFemale.Checked == false && checkBoxMale.Checked == false)
                {
                    DatingFeature.RequiredGender = null;
                }
            }
            setButtonMatchState();
        }
        
        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            buttonLogout.Enabled = !checkBoxRememberMe.Checked;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            disposeApp();
            base.OnFormClosing(e);
        }

        protected override void OnShown(EventArgs e)
        {
            initApp();
            base.OnShown(e);
        }

        private void disposeApp()
        {
            r_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            r_AppSettings.LastAccessToken = m_AccessToken;
            r_AppSettings.SaveToFile();
        }

        private void initApp()
        {
            if (r_AppSettings.RememberUser
                && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
            }
            else
            {
                userLogin();
            }

            m_AccessToken = m_LoginResult.AccessToken;
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            fetchUserData();
            buildFeaturesSetting();
        }

        private void replacePictureBoxGame()
        {
            switch (VMGameBoard.PictureGameAlbumIndex)
            {
                case 0:
                    pictureBox1.LoadAsync(VMGameBoard.GetPicUrlByIndex(0));
                    break;
                case 1:
                    pictureBox2.LoadAsync(VMGameBoard.GetPicUrlByIndex(1));
                    break;
                case 2:
                    pictureBox3.LoadAsync(VMGameBoard.GetPicUrlByIndex(2));
                    break;
                case 3:
                    pictureBox4.LoadAsync(VMGameBoard.GetPicUrlByIndex(3));
                    break;
            }
        }

        private void labelPics_Paint(object sender, PaintEventArgs e)
        {
             if(AppSettings.IsFeatureOpen(this.Size))
             {
                setPictureBoxsAndLablesForGame();
            }
        }
        
        private void setPictureBoxsAndLablesForGame()
        {
            if (VMGameBoard.IsFeatureAvailable)
            { // setting the game if user have more then 4 albums with pic and loction
                bool pictureboxState = true;
                setAlbumPictuersGame();
                setPictureBoxsState(pictureboxState);
            }
            else if(VMGameBoard.GameSet)
            {
                abortAlbumGame();
            }
        }

        private void pictureBoxGame_Click(object sender, EventArgs e)
        {
            VMGameBoard.InitPictureGameDetails(int.Parse((sender as PictureBox).Tag.ToString()));
            DialogResult res = r_PictureGameForm.ShowDialog();

            if(res == DialogResult.Yes)
            {
                VMGameBoard.ReplaceRightAnswerPictureURL();
                replacePictureBoxGame();
            }

            updatePointsLable();
        }

        private void updatePointsLable()
        {
            labelGamePoints.Text = string.Format("You earn {0} points in game", VMGameBoard.Points);
        }

        private void buttonGameOption_Click(object sender, EventArgs e)
        {
            Button currBtn = sender as Button;
            VMGameBoard.SetCommand(currBtn.Text);
            VMGameBoard.CreatePicturesGameFeature(m_LoggedInUser.Albums);
            setPictureBoxsAndLablesForGame();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton currRadio = sender as RadioButton;
            if(currRadio.Checked)
            {
                if (currRadio.Text.Equals("Date"))
                {
                    new SortListByDate(listBoxPosts).Sort();
                }

                if (currRadio.Text.Equals("Name"))
                {
                    new SortListByName(listBoxPosts).Sort();
                }
            }
        }
    }
}