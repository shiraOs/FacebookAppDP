namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetails));
            this.labelTitleName = new System.Windows.Forms.Label();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.labelLine3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleName
            // 
            this.labelTitleName.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitleName.ForeColor = System.Drawing.Color.Black;
            this.labelTitleName.Location = new System.Drawing.Point(13, 30);
            this.labelTitleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(358, 79);
            this.labelTitleName.TabIndex = 0;
            this.labelTitleName.Text = "TitleName";
            this.labelTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLine1
            // 
            this.labelLine1.BackColor = System.Drawing.SystemColors.Control;
            this.labelLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLine1.ForeColor = System.Drawing.Color.Black;
            this.labelLine1.Location = new System.Drawing.Point(13, 325);
            this.labelLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(358, 38);
            this.labelLine1.TabIndex = 1;
            this.labelLine1.Text = "First Line";
            this.labelLine1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelLine2
            // 
            this.labelLine2.BackColor = System.Drawing.SystemColors.Control;
            this.labelLine2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLine2.ForeColor = System.Drawing.Color.Black;
            this.labelLine2.Location = new System.Drawing.Point(13, 372);
            this.labelLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(358, 31);
            this.labelLine2.TabIndex = 3;
            this.labelLine2.Text = "Second Line";
            this.labelLine2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLine3
            // 
            this.labelLine3.BackColor = System.Drawing.SystemColors.Control;
            this.labelLine3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLine3.ForeColor = System.Drawing.Color.Black;
            this.labelLine3.Location = new System.Drawing.Point(16, 421);
            this.labelLine3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine3.Name = "labelLine3";
            this.labelLine3.Size = new System.Drawing.Size(363, 31);
            this.labelLine3.TabIndex = 4;
            this.labelLine3.Text = "Third Line";
            this.labelLine3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDeatils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 469);
            this.Controls.Add(this.labelLine3);
            this.Controls.Add(this.labelLine2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLine1);
            this.Controls.Add(this.labelTitleName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeatils";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TitleName";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitleName;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label labelLine3;
    }
}