using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C20_Ex02_Shira_311119002_Yair_305789596
{
    public partial class FormAlbum : Form
    {
        public FormAlbum()
        {
            InitializeComponent();
        }

        public void BuildForm(Album i_SelectedAlbum)
        {
            albumBindingSource.DataSource = i_SelectedAlbum;
            this.Text = i_SelectedAlbum.Name;
        }
    }
}
