namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbum));
            this.labelPictureCount = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCreateDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPictureCount
            // 
            this.labelPictureCount.BackColor = System.Drawing.SystemColors.Control;
            this.labelPictureCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPictureCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0 Pictures", "0 Pictures in the album"));
            this.labelPictureCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPictureCount.ForeColor = System.Drawing.Color.Black;
            this.labelPictureCount.Location = new System.Drawing.Point(12, 342);
            this.labelPictureCount.Name = "labelPictureCount";
            this.labelPictureCount.Size = new System.Drawing.Size(272, 25);
            this.labelPictureCount.TabIndex = 9;
            this.labelPictureCount.Text = "Picture Count";
            this.labelPictureCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // labelCreateDate
            // 
            this.labelCreateDate.BackColor = System.Drawing.SystemColors.Control;
            this.labelCreateDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCreateDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.labelCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCreateDate.ForeColor = System.Drawing.Color.Black;
            this.labelCreateDate.Location = new System.Drawing.Point(12, 306);
            this.labelCreateDate.Name = "labelCreateDate";
            this.labelCreateDate.Size = new System.Drawing.Size(272, 25);
            this.labelCreateDate.TabIndex = 8;
            this.labelCreateDate.Text = "Create Date";
            this.labelCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "PictureAlbumURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.Location = new System.Drawing.Point(63, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelPlace
            // 
            this.labelPlace.BackColor = System.Drawing.SystemColors.Control;
            this.labelPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "Taken in 0"));
            this.labelPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlace.ForeColor = System.Drawing.Color.Black;
            this.labelPlace.Location = new System.Drawing.Point(12, 264);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(272, 31);
            this.labelPlace.TabIndex = 6;
            this.labelPlace.Text = "Place";
            this.labelPlace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(272, 80);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Album Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 387);
            this.Controls.Add(this.labelPictureCount);
            this.Controls.Add(this.labelCreateDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlbum";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPictureCount;
        private System.Windows.Forms.Label labelCreateDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.BindingSource albumBindingSource;
    }
}