namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public partial class FormApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.lableName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.lableFriends = new System.Windows.Forms.Label();
            this.lableAlbums = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelPics = new System.Windows.Forms.Label();
            this.labelSubAlbumGame = new System.Windows.Forms.Label();
            this.labelGamePoints = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelDating = new System.Windows.Forms.Label();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.listBoxAgeRange = new System.Windows.Forms.ListBox();
            this.listBoxMatchingFriends = new System.Windows.Forms.ListBox();
            this.buttonOpenFeature = new System.Windows.Forms.Button();
            this.labelSelectedPost = new System.Windows.Forms.Label();
            this.labelPostMessage = new System.Windows.Forms.Label();
            this.labelPostDate = new System.Windows.Forms.Label();
            this.textBoxPostMsg = new System.Windows.Forms.TextBox();
            this.textBoxPostDate = new System.Windows.Forms.TextBox();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.labelPostPic = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.labelAbout = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.buttonGameLocation = new System.Windows.Forms.Button();
            this.buttonGameNumbers = new System.Windows.Forms.Button();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(181, 113);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 45;
            emailLabel.Text = "Email:";
            // 
            // pictureProfile
            // 
            this.pictureProfile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.pictureProfile.Location = new System.Drawing.Point(29, 16);
            this.pictureProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(147, 129);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProfile.TabIndex = 2;
            this.pictureProfile.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(452, 50);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(168, 244);
            this.listBoxFriends.TabIndex = 3;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(860, 50);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(172, 244);
            this.listBoxAlbums.TabIndex = 4;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxPosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(645, 50);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(191, 244);
            this.listBoxPosts.TabIndex = 5;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Location = new System.Drawing.Point(184, 20);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(49, 17);
            this.lableName.TabIndex = 6;
            this.lableName.Text = "Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.textBoxFirstName.Location = new System.Drawing.Point(276, 20);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(112, 22);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(181, 50);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(60, 17);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Gender:";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(276, 49);
            this.textBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(112, 22);
            this.textBoxGender.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(748, 650);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "1";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBoxGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(747, 516);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxGame_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(888, 516);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "2";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBoxGame_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Teal;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(888, 650);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "3";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBoxGame_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(181, 81);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(64, 17);
            this.labelBirthday.TabIndex = 15;
            this.labelBirthday.Text = "Birthday:";
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.textBoxBirthday.Location = new System.Drawing.Point(276, 79);
            this.textBoxBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.ReadOnly = true;
            this.textBoxBirthday.Size = new System.Drawing.Size(112, 22);
            this.textBoxBirthday.TabIndex = 16;
            // 
            // lableFriends
            // 
            this.lableFriends.AutoSize = true;
            this.lableFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lableFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.lableFriends.Location = new System.Drawing.Point(471, 16);
            this.lableFriends.Name = "lableFriends";
            this.lableFriends.Size = new System.Drawing.Size(119, 25);
            this.lableFriends.TabIndex = 17;
            this.lableFriends.Text = "My Friends";
            // 
            // lableAlbums
            // 
            this.lableAlbums.AutoSize = true;
            this.lableAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lableAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.lableAlbums.Location = new System.Drawing.Point(887, 17);
            this.lableAlbums.Name = "lableAlbums";
            this.lableAlbums.Size = new System.Drawing.Size(119, 25);
            this.lableAlbums.TabIndex = 18;
            this.lableAlbums.Text = "My Albums";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.labelPosts.Location = new System.Drawing.Point(683, 16);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(101, 25);
            this.labelPosts.TabIndex = 19;
            this.labelPosts.Text = "My Posts";
            // 
            // labelPics
            // 
            this.labelPics.AutoSize = true;
            this.labelPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelPics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.labelPics.Location = new System.Drawing.Point(748, 352);
            this.labelPics.Name = "labelPics";
            this.labelPics.Size = new System.Drawing.Size(241, 31);
            this.labelPics.TabIndex = 20;
            this.labelPics.Text = "My Albums Game";
            this.labelPics.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPics_Paint);
            // 
            // labelSubAlbumGame
            // 
            this.labelSubAlbumGame.AutoSize = true;
            this.labelSubAlbumGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSubAlbumGame.Location = new System.Drawing.Point(780, 474);
            this.labelSubAlbumGame.Name = "labelSubAlbumGame";
            this.labelSubAlbumGame.Size = new System.Drawing.Size(191, 20);
            this.labelSubAlbumGame.TabIndex = 21;
            this.labelSubAlbumGame.Text = "Press the picture to play";
            // 
            // labelGamePoints
            // 
            this.labelGamePoints.AutoSize = true;
            this.labelGamePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGamePoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGamePoints.Location = new System.Drawing.Point(780, 789);
            this.labelGamePoints.Name = "labelGamePoints";
            this.labelGamePoints.Size = new System.Drawing.Size(203, 20);
            this.labelGamePoints.TabIndex = 24;
            this.labelGamePoints.Text = "You earn 0 points in game";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(24, 820);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberMe.TabIndex = 25;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.Location = new System.Drawing.Point(19, 775);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(127, 39);
            this.buttonLogout.TabIndex = 26;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelDating
            // 
            this.labelDating.AutoSize = true;
            this.labelDating.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.labelDating.Location = new System.Drawing.Point(71, 351);
            this.labelDating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDating.Name = "labelDating";
            this.labelDating.Size = new System.Drawing.Size(186, 31);
            this.labelDating.TabIndex = 27;
            this.labelDating.Text = "Dating Match";
            this.labelDating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(84, 399);
            this.checkBoxMale.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(60, 21);
            this.checkBoxMale.TabIndex = 28;
            this.checkBoxMale.Tag = "";
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxGender_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(181, 399);
            this.checkBoxFemale.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(76, 21);
            this.checkBoxFemale.TabIndex = 29;
            this.checkBoxFemale.Tag = "";
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxGender_CheckedChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(128, 427);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(79, 17);
            this.labelAge.TabIndex = 31;
            this.labelAge.Text = "Age Range";
            // 
            // buttonMatch
            // 
            this.buttonMatch.Enabled = false;
            this.buttonMatch.Location = new System.Drawing.Point(84, 502);
            this.buttonMatch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(183, 28);
            this.buttonMatch.TabIndex = 32;
            this.buttonMatch.Text = "Find my match!";
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // listBoxAgeRange
            // 
            this.listBoxAgeRange.FormattingEnabled = true;
            this.listBoxAgeRange.ItemHeight = 16;
            this.listBoxAgeRange.Items.AddRange(new object[] {
            "15-18",
            "19-23",
            "24-30",
            "30-40",
            "40+"});
            this.listBoxAgeRange.Location = new System.Drawing.Point(95, 452);
            this.listBoxAgeRange.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAgeRange.Name = "listBoxAgeRange";
            this.listBoxAgeRange.Size = new System.Drawing.Size(159, 36);
            this.listBoxAgeRange.TabIndex = 33;
            this.listBoxAgeRange.SelectedIndexChanged += new System.EventHandler(this.listBoxAgeRange_SelectedIndexChanged);
            // 
            // listBoxMatchingFriends
            // 
            this.listBoxMatchingFriends.FormattingEnabled = true;
            this.listBoxMatchingFriends.ItemHeight = 16;
            this.listBoxMatchingFriends.Location = new System.Drawing.Point(84, 538);
            this.listBoxMatchingFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMatchingFriends.Name = "listBoxMatchingFriends";
            this.listBoxMatchingFriends.Size = new System.Drawing.Size(181, 180);
            this.listBoxMatchingFriends.TabIndex = 34;
            this.listBoxMatchingFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // buttonOpenFeature
            // 
            this.buttonOpenFeature.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonOpenFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOpenFeature.Location = new System.Drawing.Point(29, 197);
            this.buttonOpenFeature.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFeature.Name = "buttonOpenFeature";
            this.buttonOpenFeature.Size = new System.Drawing.Size(251, 70);
            this.buttonOpenFeature.TabIndex = 35;
            this.buttonOpenFeature.Text = "Open Features";
            this.buttonOpenFeature.UseVisualStyleBackColor = false;
            this.buttonOpenFeature.Click += new System.EventHandler(this.buttonOpenFeature_Click);
            // 
            // labelSelectedPost
            // 
            this.labelSelectedPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSelectedPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(64)))), ((int)(((byte)(124)))));
            this.labelSelectedPost.Location = new System.Drawing.Point(347, 352);
            this.labelSelectedPost.Name = "labelSelectedPost";
            this.labelSelectedPost.Size = new System.Drawing.Size(315, 36);
            this.labelSelectedPost.TabIndex = 36;
            this.labelSelectedPost.Text = "Press Post to Display";
            this.labelSelectedPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPostMessage
            // 
            this.labelPostMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostMessage.Location = new System.Drawing.Point(355, 393);
            this.labelPostMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostMessage.Name = "labelPostMessage";
            this.labelPostMessage.Size = new System.Drawing.Size(292, 28);
            this.labelPostMessage.TabIndex = 37;
            this.labelPostMessage.Text = "Post Message";
            this.labelPostMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPostDate
            // 
            this.labelPostDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostDate.Location = new System.Drawing.Point(349, 562);
            this.labelPostDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostDate.Name = "labelPostDate";
            this.labelPostDate.Size = new System.Drawing.Size(292, 28);
            this.labelPostDate.TabIndex = 38;
            this.labelPostDate.Text = "Post Date";
            this.labelPostDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPostMsg
            // 
            this.textBoxPostMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPostMsg.Location = new System.Drawing.Point(387, 423);
            this.textBoxPostMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostMsg.Multiline = true;
            this.textBoxPostMsg.Name = "textBoxPostMsg";
            this.textBoxPostMsg.ReadOnly = true;
            this.textBoxPostMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPostMsg.Size = new System.Drawing.Size(237, 130);
            this.textBoxPostMsg.TabIndex = 39;
            this.textBoxPostMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPostDate
            // 
            this.textBoxPostDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPostDate.Location = new System.Drawing.Point(387, 594);
            this.textBoxPostDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostDate.Multiline = true;
            this.textBoxPostDate.Name = "textBoxPostDate";
            this.textBoxPostDate.ReadOnly = true;
            this.textBoxPostDate.Size = new System.Drawing.Size(214, 24);
            this.textBoxPostDate.TabIndex = 40;
            this.textBoxPostDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.BackColor = System.Drawing.Color.Teal;
            this.pictureBoxPost.Location = new System.Drawing.Point(387, 654);
            this.pictureBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(215, 169);
            this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPost.TabIndex = 41;
            this.pictureBoxPost.TabStop = false;
            // 
            // labelPostPic
            // 
            this.labelPostPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostPic.Location = new System.Drawing.Point(355, 622);
            this.labelPostPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostPic.Name = "labelPostPic";
            this.labelPostPic.Size = new System.Drawing.Size(292, 28);
            this.labelPostPic.TabIndex = 42;
            this.labelPostPic.Text = "Post Picture";
            this.labelPostPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelError.Location = new System.Drawing.Point(684, 514);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 43;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.textBoxAbout.Location = new System.Drawing.Point(95, 150);
            this.textBoxAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(321, 22);
            this.textBoxAbout.TabIndex = 45;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(25, 153);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(49, 17);
            this.labelAbout.TabIndex = 44;
            this.labelAbout.Text = "About:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(251, 110);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(165, 22);
            this.emailTextBox.TabIndex = 46;
            // 
            // buttonGameLocation
            // 
            this.buttonGameLocation.Location = new System.Drawing.Point(782, 394);
            this.buttonGameLocation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGameLocation.Name = "buttonGameLocation";
            this.buttonGameLocation.Size = new System.Drawing.Size(184, 28);
            this.buttonGameLocation.TabIndex = 47;
            this.buttonGameLocation.Text = "Locations Game";
            this.buttonGameLocation.UseVisualStyleBackColor = true;
            this.buttonGameLocation.Click += new System.EventHandler(this.buttonGameOption_Click);
            // 
            // buttonGameNumbers
            // 
            this.buttonGameNumbers.Location = new System.Drawing.Point(783, 433);
            this.buttonGameNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGameNumbers.Name = "buttonGameNumbers";
            this.buttonGameNumbers.Size = new System.Drawing.Size(185, 28);
            this.buttonGameNumbers.TabIndex = 48;
            this.buttonGameNumbers.Text = "Numbers Game";
            this.buttonGameNumbers.UseVisualStyleBackColor = true;
            this.buttonGameNumbers.Click += new System.EventHandler(this.buttonGameOption_Click);
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(641, 299);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(73, 21);
            this.labelSortBy.TabIndex = 50;
            this.labelSortBy.Text = "Sort By:";
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(705, 299);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(59, 21);
            this.radioButtonDate.TabIndex = 51;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "Date";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(770, 299);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(66, 21);
            this.radioButtonName.TabIndex = 52;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 844);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.radioButtonDate);
            this.Controls.Add(this.labelSortBy);
            this.Controls.Add(this.buttonGameNumbers);
            this.Controls.Add(this.buttonGameLocation);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelPostPic);
            this.Controls.Add(this.pictureBoxPost);
            this.Controls.Add(this.textBoxPostDate);
            this.Controls.Add(this.textBoxPostMsg);
            this.Controls.Add(this.labelPostDate);
            this.Controls.Add(this.labelPostMessage);
            this.Controls.Add(this.labelSelectedPost);
            this.Controls.Add(this.buttonOpenFeature);
            this.Controls.Add(this.listBoxMatchingFriends);
            this.Controls.Add(this.listBoxAgeRange);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelDating);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.labelGamePoints);
            this.Controls.Add(this.labelSubAlbumGame);
            this.Controls.Add(this.labelPics);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.lableAlbums);
            this.Controls.Add(this.lableFriends);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lableName);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureProfile);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.Label lableFriends;
        private System.Windows.Forms.Label lableAlbums;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelPics;
        private System.Windows.Forms.Label labelSubAlbumGame;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelDating;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.ListBox listBoxAgeRange;
        private System.Windows.Forms.ListBox listBoxMatchingFriends;
        private System.Windows.Forms.Button buttonOpenFeature;
        private System.Windows.Forms.Label labelSelectedPost;
        private System.Windows.Forms.Label labelPostMessage;
        private System.Windows.Forms.Label labelPostDate;
        private System.Windows.Forms.TextBox textBoxPostMsg;
        private System.Windows.Forms.TextBox textBoxPostDate;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Label labelPostPic;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelGamePoints;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button buttonGameLocation;
        private System.Windows.Forms.Button buttonGameNumbers;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.RadioButton radioButtonName;
    }
}