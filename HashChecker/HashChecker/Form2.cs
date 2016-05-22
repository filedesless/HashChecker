using HashChecker.Utilities;
using System.Windows.Forms;

namespace HashChecker
{
    public partial class frmPublisher : Form
    {
        public frmPublisher(string hashes)
        {
            InitializeComponent();

            txtOutput.Text = hashes;
        }

        private void txtInput_TextChanged(object sender, System.EventArgs e)
        {
            displaying.compareTextBoxes(txtInput, txtOutput);
        }
    }
}
