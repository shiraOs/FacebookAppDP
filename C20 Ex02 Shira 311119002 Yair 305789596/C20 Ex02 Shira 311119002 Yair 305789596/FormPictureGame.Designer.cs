namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormPictureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPictureGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer4 = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.Location = new System.Drawing.Point(108, 357);
            this.buttonAnswer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(227, 46);
            this.buttonAnswer1.TabIndex = 1;
            this.buttonAnswer1.Text = "button1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            this.buttonAnswer1.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.Location = new System.Drawing.Point(108, 410);
            this.buttonAnswer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(227, 46);
            this.buttonAnswer2.TabIndex = 2;
            this.buttonAnswer2.Text = "button2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.Location = new System.Drawing.Point(108, 463);
            this.buttonAnswer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(227, 46);
            this.buttonAnswer3.TabIndex = 3;
            this.buttonAnswer3.Text = "button3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            this.buttonAnswer3.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.Location = new System.Drawing.Point(108, 516);
            this.buttonAnswer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(227, 46);
            this.buttonAnswer4.TabIndex = 4;
            this.buttonAnswer4.Text = "button4";
            this.buttonAnswer4.UseVisualStyleBackColor = true;
            this.buttonAnswer4.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestion.Location = new System.Drawing.Point(59, 22);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(327, 29);
            this.labelQuestion.TabIndex = 5;
            this.labelQuestion.Text = "Where the picture was taken?";
            // 
            // FormPictureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 602);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonAnswer4);
            this.Controls.Add(this.buttonAnswer3);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.buttonAnswer1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPictureGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album Location Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAnswer1;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Button buttonAnswer3;
        private System.Windows.Forms.Button buttonAnswer4;
        private System.Windows.Forms.Label labelQuestion;
    }
}