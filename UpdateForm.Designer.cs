namespace SlidelyFormApp
{
    partial class UpdateForm
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
            lblGithub = new Label();
            lblStopwatch = new Label();
            txtStopwatchTime = new TextBox();
            txtGithubLink = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            btnSubmitUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(238, 106);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(238, 159);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(238, 212);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(77, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone No:";
            // 
            // lblGithub
            // 
            lblGithub.AutoSize = true;
            lblGithub.Location = new Point(238, 265);
            lblGithub.Name = "lblGithub";
            lblGithub.Size = new Size(83, 20);
            lblGithub.TabIndex = 3;
            lblGithub.Text = "Github Link";
            // 
            // lblStopwatch
            // 
            lblStopwatch.AutoSize = true;
            lblStopwatch.Location = new Point(238, 321);
            lblStopwatch.Name = "lblStopwatch";
            lblStopwatch.Size = new Size(116, 20);
            lblStopwatch.TabIndex = 4;
            lblStopwatch.Text = "Stopwatch Time";
            // 
            // txtStopwatchTime
            // 
            txtStopwatchTime.BorderStyle = BorderStyle.FixedSingle;
            txtStopwatchTime.Location = new Point(418, 321);
            txtStopwatchTime.Name = "txtStopwatchTime";
            txtStopwatchTime.Size = new Size(252, 27);
            txtStopwatchTime.TabIndex = 5;
            // 
            // txtGithubLink
            // 
            txtGithubLink.BackColor = SystemColors.Window;
            txtGithubLink.BorderStyle = BorderStyle.FixedSingle;
            txtGithubLink.Location = new Point(418, 265);
            txtGithubLink.Name = "txtGithubLink";
            txtGithubLink.Size = new Size(252, 27);
            txtGithubLink.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(418, 212);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(252, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(418, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(418, 106);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 9;
            // 
            // btnSubmitUpdate
            // 
            btnSubmitUpdate.BackColor = Color.Orchid;
            btnSubmitUpdate.FlatStyle = FlatStyle.Flat;
            btnSubmitUpdate.Location = new Point(238, 399);
            btnSubmitUpdate.Name = "btnSubmitUpdate";
            btnSubmitUpdate.Size = new Size(193, 29);
            btnSubmitUpdate.TabIndex = 10;
            btnSubmitUpdate.Text = "Submit Update";
            btnSubmitUpdate.UseVisualStyleBackColor = false;
            btnSubmitUpdate.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkTurquoise;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(489, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(181, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 500);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmitUpdate);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtGithubLink);
            Controls.Add(txtStopwatchTime);
            Controls.Add(lblStopwatch);
            Controls.Add(lblGithub);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblGithub;
        private Label lblStopwatch;
        private TextBox txtStopwatchTime;
        private TextBox txtGithubLink;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnSubmitUpdate;
        private Button btnCancel;
    }
}