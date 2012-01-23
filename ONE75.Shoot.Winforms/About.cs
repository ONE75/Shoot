using System.Windows.Forms;

namespace ONE75.Shoot.Winforms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linklabel = sender as LinkLabel;
            if (linklabel != null)
                System.Diagnostics.Process.Start(linklabel.Text);
        }
    }
}