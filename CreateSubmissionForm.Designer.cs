namespace SlidelyFormApp
{
    partial class CreateSubmissionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer2 = new System.Windows.Forms.Timer(components);
            lblStopwatch = new Label();
            btnToggleStopwatch = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtGithubLink = new TextBox();
            btnSubmit = new Button();
            lblEmail = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblGithub = new Label();
            SuspendLayout();
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // lblStopwatch
            // 
            lblStopwatch.AutoSize = true;
            lblStopwatch.Location = new Point(510, 317);
            lblStopwatch.Name = "lblStopwatch";
            lblStopwatch.Size = new Size(50, 20);
            lblStopwatch.TabIndex = 0;
            lblStopwatch.Text = "label1";
            lblStopwatch.Click += lblStopwatch_Click;
            // 
            // btnToggleStopwatch
            // 
            btnToggleStopwatch.BackColor = Color.Khaki;
            btnToggleStopwatch.FlatStyle = FlatStyle.Flat;
            btnToggleStopwatch.Location = new Point(205, 309);
            btnToggleStopwatch.Name = "btnToggleStopwatch";
            btnToggleStopwatch.Size = new Size(229, 37);
            btnToggleStopwatch.TabIndex = 1;
            btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)";
            btnToggleStopwatch.UseVisualStyleBackColor = false;
            btnToggleStopwatch.Click += btnToggleStopwatch_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(376, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(376, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(376, 200);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtGithubLink
            // 
            txtGithubLink.BorderStyle = BorderStyle.FixedSingle;
            txtGithubLink.Location = new Point(376, 248);
            txtGithubLink.Name = "txtGithubLink";
            txtGithubLink.Size = new Size(200, 27);
            txtGithubLink.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.CornflowerBlue;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(289, 363);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(271, 38);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "SUBMIT (CTRL + S)";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(206, 157);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(206, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(205, 207);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(77, 20);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone No.";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblGithub
            // 
            lblGithub.AutoSize = true;
            lblGithub.Location = new Point(205, 255);
            lblGithub.Name = "lblGithub";
            lblGithub.Size = new Size(83, 20);
            lblGithub.TabIndex = 11;
            lblGithub.Text = "Github Link";
            // 
            // CreateSubmissionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGithub);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(btnSubmit);
            Controls.Add(txtGithubLink);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnToggleStopwatch);
            Controls.Add(lblStopwatch);
            Name = "CreateSubmissionForm";
            Text = "CreateSubmissionForm";
            Load += CreateSubmissionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStopwatch;
        private Button btnToggleStopwatch;
        private System.Windows.Forms.Timer timer2;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtGithubLink;
        private Button btnSubmit;
        private Label lblEmail;
        private Label lblName;
        private Label lblPhone;
        private Label lblGithub;
    }
}
