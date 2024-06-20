namespace SlidelyFormApp
{
    partial class ViewSubmissionsForm
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
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblStopwatch = new Label();
            lblGithub = new Label();
            txtStopwatchTime = new TextBox();
            txtGithubLink = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            btnPrevious = new Button();
            btnNext = new Button();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(196, 92);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(196, 141);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(196, 186);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(86, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Num";
            // 
            // lblStopwatch
            // 
            lblStopwatch.AutoSize = true;
            lblStopwatch.Location = new Point(196, 275);
            lblStopwatch.Name = "lblStopwatch";
            lblStopwatch.Size = new Size(116, 20);
            lblStopwatch.TabIndex = 3;
            lblStopwatch.Text = "Stopwatch Time";
            // 
            // lblGithub
            // 
            lblGithub.AutoSize = true;
            lblGithub.Location = new Point(196, 230);
            lblGithub.Name = "lblGithub";
            lblGithub.Size = new Size(83, 20);
            lblGithub.TabIndex = 4;
            lblGithub.Text = "Github Link";
            // 
            // txtStopwatchTime
            // 
            txtStopwatchTime.BackColor = SystemColors.ControlLight;
            txtStopwatchTime.BorderStyle = BorderStyle.FixedSingle;
            txtStopwatchTime.Location = new Point(378, 275);
            txtStopwatchTime.Name = "txtStopwatchTime";
            txtStopwatchTime.ReadOnly = true;
            txtStopwatchTime.Size = new Size(264, 27);
            txtStopwatchTime.TabIndex = 5;
            // 
            // txtGithubLink
            // 
            txtGithubLink.BackColor = SystemColors.ControlLight;
            txtGithubLink.BorderStyle = BorderStyle.FixedSingle;
            txtGithubLink.Location = new Point(378, 223);
            txtGithubLink.Name = "txtGithubLink";
            txtGithubLink.ReadOnly = true;
            txtGithubLink.Size = new Size(264, 27);
            txtGithubLink.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ControlLight;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(378, 179);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(264, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(378, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(264, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ControlLight;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(378, 85);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(264, 27);
            txtName.TabIndex = 9;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Khaki;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(146, 367);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(166, 29);
            btnPrevious.TabIndex = 10;
            btnPrevious.Text = "Previous(CTRL + P)";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.CornflowerBlue;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(356, 367);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(166, 29);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next(CTRL + N)";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 34);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 12;
            label1.Text = "Abhijeet Singh,Slidely Task 2 - View Submissions";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(564, 367);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(730, 367);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ViewSubmissionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 524);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtGithubLink);
            Controls.Add(txtStopwatchTime);
            Controls.Add(lblGithub);
            Controls.Add(lblStopwatch);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            KeyPreview = true;
            Name = "ViewSubmissionsForm";
            Text = "ViewSubmissionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblStopwatch;
        private Label lblGithub;
        private TextBox txtStopwatchTime;
        private TextBox txtGithubLink;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnPrevious;
        private Button btnNext;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
