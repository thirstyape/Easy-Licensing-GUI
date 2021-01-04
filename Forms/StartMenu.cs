using System;
using System.Windows.Forms;

namespace Easy_Licensing_GUI.Forms
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void ButtonGenerateLicense_Click(object sender, EventArgs e)
        {
            var generator = new LicenseGeneration();

            generator.ShowDialog();
        }

        private void ButtonCheckLicense_Click(object sender, EventArgs e)
        {
            var checker = new LicenseCheck();

            checker.ShowDialog();
        }

        private void ButtonRequestLicense_Click(object sender, EventArgs e)
        {
            var requestor = new LicenseRequest();

            requestor.ShowDialog();
        }
    }
}
