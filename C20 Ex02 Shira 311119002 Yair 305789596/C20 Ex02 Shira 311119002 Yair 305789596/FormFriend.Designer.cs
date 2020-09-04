namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriend));
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(41, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(207, 44);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Friend Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGender
            // 
            this.labelGender.BackColor = System.Drawing.SystemColors.Control;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(63, 264);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(164, 31);
            this.labelGender.TabIndex = 1;
            this.labelGender.Text = "Gender";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelBirthday
            // 
            this.labelBirthday.BackColor = System.Drawing.SystemColors.Control;
            this.labelBirthday.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthday.ForeColor = System.Drawing.Color.Black;
            this.labelBirthday.Location = new System.Drawing.Point(63, 302);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(164, 25);
            this.labelBirthday.TabIndex = 3;
            this.labelBirthday.Text = "Birthday Date";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCity
            // 
            this.labelCity.BackColor = System.Drawing.SystemColors.Control;
            this.labelCity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCity.ForeColor = System.Drawing.Color.Black;
            this.labelCity.Location = new System.Drawing.Point(12, 342);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(272, 25);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 381);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFriend";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Friend";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelCity;
    }
}