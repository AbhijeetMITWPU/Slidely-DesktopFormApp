using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static SlidelyFormApp.CreateSubmissionForm;

namespace SlidelyFormApp
{
    public partial class UpdateForm : Form
    {
        private SubmissionData submissionData;

        public UpdateForm(SubmissionData submission)
        {
            InitializeComponent();
            submissionData = submission; // Store the submission data passed from ViewSubmissionsForm
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // Populate form fields with existing submission data
            txtName.Text = submissionData.Name;
            txtEmail.Text = submissionData.Email;
            txtPhoneNumber.Text = submissionData.PhoneNumber;
            txtGithubLink.Text = submissionData.GithubLink;
            txtStopwatchTime.Text = submissionData.StopwatchTime;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Update submissionData with edited values
                submissionData.Name = txtName.Text;
                submissionData.Email = txtEmail.Text;
                submissionData.PhoneNumber = txtPhoneNumber.Text;
                submissionData.GithubLink = txtGithubLink.Text;
                submissionData.StopwatchTime = txtStopwatchTime.Text;

                // Serialize the updated submissionData to JSON
                string jsonSubmissionData = JsonConvert.SerializeObject(submissionData);

                // Send updated submission data to backend for update
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        // Configure HTTP client
                        client.BaseAddress = new Uri("http://localhost:5000/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        // Create HttpContent for the JSON payload
                        var content = new StringContent(jsonSubmissionData, System.Text.Encoding.UTF8, "application/json");

                        // Send PUT request with updated submission data
                        HttpResponseMessage response = await client.PutAsync($"submission/{submissionData.Id}", content);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Submission updated successfully.");
                            DialogResult = DialogResult.OK; // Close form with OK result
                            Close(); // Close UpdateForm
                        }
                        else
                        {
                            MessageBox.Show($"Failed to update submission. Server returned error: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating submission: {ex.Message}");
                    }
                }
            }
        }

        private bool ValidateForm()
        {
            // Implement validation logic as per your requirements
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return false;
            }
            // Add more validation rules as needed

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Close form with Cancel result
            Close(); // Close UpdateForm
        }
    }
}
