using System;
using System.Windows.Forms;

namespace C20_Ex03_Shira_311119002_Yair_305789596
{
    public partial class FormDetails : Form
    {
        private Details m_Details;
        private IFormDetails m_FormDetails;

        internal FormDetails()
        {
            InitializeComponent();
        }
        
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            pictureBox1.Image = null;
        }

        internal void BuildForm(IFormDetails i_Form, object i_Object)
        {
            m_FormDetails = i_Form;
            m_Details = i_Form.CreateForm(i_Object);
        }

        protected override void OnShown(EventArgs e)
        {
            loadDetails();
        }

        private void loadDetails()
        {
            this.Text = m_Details.TitleName;
            this.labelTitleName.Text = m_Details.TitleName;
            this.pictureBox1.LoadAsync(m_Details.PictureURL);
            this.labelLine1.Text = m_Details.FirstDetailsLine;
            this.labelLine2.Text = m_Details.SecondDetailsLine;
            this.labelLine3.Text = m_Details.ThirdDetailsLine;
        }
    }
}
