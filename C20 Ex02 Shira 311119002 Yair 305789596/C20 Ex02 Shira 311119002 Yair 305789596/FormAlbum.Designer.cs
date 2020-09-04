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
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPicturesCounter = new System.Windows.Forms.Label();
            this.labelCreateDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.SystemColors.Control;
            this.labelDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(133, 325);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(150, 26);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "[Date]";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.pictureBox1.Location = new System.Drawing.Point(64, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelPlace
            // 
            this.labelPlace.BackColor = System.Drawing.SystemColors.Control;
            this.labelPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Location", true));
            this.labelPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlace.ForeColor = System.Drawing.Color.Black;
            this.labelPlace.Location = new System.Drawing.Point(11, 300);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(272, 27);
            this.labelPlace.TabIndex = 6;
            this.labelPlace.Text = "Place";
            this.labelPlace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(13, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(272, 80);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Album Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // labelPicturesCounter
            // 
            this.labelPicturesCounter.BackColor = System.Drawing.SystemColors.Control;
            this.labelPicturesCounter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPicturesCounter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0 Pictures", "0 Pictures"));
            this.labelPicturesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicturesCounter.ForeColor = System.Drawing.Color.Black;
            this.labelPicturesCounter.Location = new System.Drawing.Point(19, 351);
            this.labelPicturesCounter.Name = "labelPicturesCounter";
            this.labelPicturesCounter.Size = new System.Drawing.Size(264, 25);
            this.labelPicturesCounter.TabIndex = 10;
            this.labelPicturesCounter.Text = "[Pictures counter]";
            this.labelPicturesCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCreateDate
            // 
            this.labelCreateDate.BackColor = System.Drawing.SystemColors.Control;
            this.labelCreateDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCreateDate.ForeColor = System.Drawing.Color.Black;
            this.labelCreateDate.Location = new System.Drawing.Point(12, 325);
            this.labelCreateDate.Name = "labelCreateDate";
            this.labelCreateDate.Size = new System.Drawing.Size(128, 26);
            this.labelCreateDate.TabIndex = 11;
            this.labelCreateDate.Text = "Create Date:";
            this.labelCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 395);
            this.Controls.Add(this.labelCreateDate);
            this.Controls.Add(this.labelPicturesCounter);
            this.Controls.Add(this.labelDate);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Label labelPicturesCounter;
        private System.Windows.Forms.Label labelCreateDate;
    }
}