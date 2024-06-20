using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SlidelyFormApp
{
    public partial class CreateSubmissionForm : Form
    {
        private bool isStopwatchRunning = false;
        private TimeSpan stopwatchTime = TimeSpan.Zero;
        private List<SubmissionData> submissions = new List<SubmissionData>();

        public class SubmissionData
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("phone")]
            public string PhoneNumber { get; set; }

            [JsonProperty("github_link")]
            public string GithubLink { get; set; }

            [JsonProperty("stopwatch_time")]
            public string StopwatchTime { get; set; }
            public int Id { get; set; }



            public SubmissionData()
            {
                Name = "";
                Email = "";
                PhoneNumber = "";
                GithubLink = "";
                StopwatchTime = TimeSpan.Zero.ToString(@"hh\:mm\:ss");
            }
        }

        public CreateSubmissionForm()
        {
            InitializeComponent();
        }

        private void CreateSubmissionForm_Load(object sender, EventArgs e)
        {
            // Initialize the label with the initial stopwatch time
            lblStopwatch.Text = stopwatchTime.ToString(@"hh\:mm\:ss");
        }

        private void btnToggleStopwatch_Click(object sender, EventArgs e)
        {
            if (isStopwatchRunning)
            {
                timer2.Stop();
                btnToggleStopwatch.Text = "Start Stopwatch";
            }
            else
            {
                timer2.Start();
                btnToggleStopwatch.Text = "Stop Stopwatch";
            }

            isStopwatchRunning = !isStopwatchRunning;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1));
            lblStopwatch.Text = stopwatchTime.ToString(@"hh\:mm\:ss");
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter Name.");
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid Email address.");
                return;
            }

            if (!IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter a valid Phone Number.");
                return;
            }

            string githubLink = null;

            // Check if txtGithubLink is not null before accessing Text property
            if (txtGithubLink != null)
            {
                githubLink = txtGithubLink.Text;
            }

            if (string.IsNullOrWhiteSpace(githubLink) || !IsValidUrl(githubLink))
            {
                MessageBox.Show("Please enter a valid GitHub Link.");
                return;
            }

            // Create a new SubmissionData object
            var submission = new SubmissionData
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                GithubLink = githubLink,
                StopwatchTime = stopwatchTime.ToString(@"hh\:mm\:ss")
            };

            // Serialize submission object to JSON
            string jsonData = JsonConvert.SerializeObject(submission);

            // HttpClient setup
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");

                try
                {
                    // HTTP POST request to /submit endpoint
                    HttpResponseMessage response = await client.PostAsync("submit", new StringContent(jsonData, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        // Add submission to local list if needed
                        // submissions.Add(submission);

                        // Clear input fields and reset stopwatch
                        ClearInputFields();

                        // Notify user
                        MessageBox.Show("Submission saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save submission. Server returned error: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting to server: " + ex.Message);
                }
            }
        }



        private void ClearInputFields()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtGithubLink.Text = "";
            stopwatchTime = TimeSpan.Zero;
            lblStopwatch.Text = stopwatchTime.ToString(@"hh\:mm\:ss");
            isStopwatchRunning = false;
            btnToggleStopwatch.Text = "Start Stopwatch";
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return false;
            }
            return Regex.IsMatch(phoneNumber, @"^\+?\d{0,2}\s?\(?\d{1,3}\)?[-.\s]?\d{3,4}[-.\s]?\d{4}$");
        }

        private bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblStopwatch_Click(object sender, EventArgs e)
        {

        }
    }
}
