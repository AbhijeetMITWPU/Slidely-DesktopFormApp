using System;
using System.Windows.Forms;

namespace SlidelyFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Enable the form to capture key events
            this.KeyPreview = true;

            // Register the KeyDown event handler
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                btnViewSubmissions.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                btnCreateSubmission.PerformClick();
            }
        }

        private void btnCreateSubmission_Click(object sender, EventArgs e)
        {
            CreateSubmissionForm createForm = new CreateSubmissionForm();
            createForm.Show();
        }

        private void btnViewSubmissions_Click(object sender, EventArgs e)
        {
            ViewSubmissionsForm viewForm = new ViewSubmissionsForm();
            viewForm.Show();
        }
    }
}
