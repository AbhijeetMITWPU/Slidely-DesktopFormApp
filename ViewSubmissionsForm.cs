using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static SlidelyFormApp.CreateSubmissionForm;

namespace SlidelyFormApp
{
    public partial class ViewSubmissionsForm : Form
    {
        private List<SubmissionData> submissions;
        private int currentIndex = 0;

        public ViewSubmissionsForm()
        {
            InitializeComponent();
            FetchSubmissions(); // Fetch submissions when the form is initialized
        }

        private async void FetchSubmissions()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:5000/read");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        submissions = JsonConvert.DeserializeObject<List<SubmissionData>>(json);

                        if (submissions != null && submissions.Count > 0)
                        {
                            DisplaySubmission(currentIndex); // Display the first submission
                        }
                        else
                        {
                            MessageBox.Show("No submissions found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve submissions. Server returned error: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting to server: " + ex.Message);
                }
            }
        }

        private void DisplaySubmission(int index)
        {
            if (submissions != null && index >= 0 && index < submissions.Count)
            {
                var submission = submissions[index];
                txtName.Text = submission.Name;
                txtEmail.Text = submission.Email;
                txtPhoneNumber.Text = submission.PhoneNumber;
                txtGithubLink.Text = submission.GithubLink;
                txtStopwatchTime.Text = submission.StopwatchTime;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (submissions != null && currentIndex > 0)
            {
                currentIndex--;
                DisplaySubmission(currentIndex);
            }
            else
            {
                MessageBox.Show("Already at the first submission.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (submissions != null && currentIndex < submissions.Count - 1)
            {
                currentIndex++;
                DisplaySubmission(currentIndex);
            }
            else
            {
                MessageBox.Show("Already at the last submission.");
            }
        }
        // Delete button click event handler
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (submissions != null && currentIndex >= 0 && currentIndex < submissions.Count)
            {
                int submissionIdToDelete = submissions[currentIndex].Id;

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync($"http://localhost:5000/submission/{submissionIdToDelete}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Submission deleted successfully.");
                            // Optionally refresh the submissions list or navigate to next/previous submission
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete submission. Server returned error: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting submission: {ex.Message}");
                    }
                }
            }
        }



        private void ViewSubmissionsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.P)
                {
                    // Ctrl+P pressed, navigate to previous submission
                    btnPrevious_Click(sender, e);
                }
                else if (e.KeyCode == Keys.N)
                {
                    // Ctrl+N pressed, navigate to next submission
                    btnNext_Click(sender, e);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (submissions != null && currentIndex >= 0 && currentIndex < submissions.Count)
            {
                var submissionToUpdate = submissions[currentIndex];

                // Create an instance of UpdateForm and pass the current submission data to it
                UpdateForm updateForm = new UpdateForm(submissionToUpdate);

                // Show the UpdateForm
                updateForm.ShowDialog();

                // After UpdateForm is closed, fetch updated submissions
                FetchSubmissions();
            }
            else
            {
                MessageBox.Show("No submission to update.");
            }
        }

    }
}
