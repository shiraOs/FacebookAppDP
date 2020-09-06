using System;
using System.Windows.Forms;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormDeatils : Form
    {
        internal interface IFormDeatils
        {
            string TitleName { get; set; }
            string PictureURL { get; set; }
            string FirstDetailsLine { get; set; }
            string SecondDetailsLine { get; set; }
            string ThirdDetailsLine { get; set; }
        }

        internal FormDeatils()
        {
            InitializeComponent();
        }

        internal void BuildForm(IFormDeatils i_Form)
        {
            this.Text = i_Form.TitleName;
            this.labelTitleName.Text = i_Form.TitleName;
            this.pictureBox1.LoadAsync(i_Form.PictureURL);
            this.labelLine1.Text = i_Form.FirstDetailsLine;
            this.labelLine2.Text = i_Form.SecondDetailsLine;
            this.labelLine3.Text = i_Form.ThirdDetailsLine;
        }
    }
}
