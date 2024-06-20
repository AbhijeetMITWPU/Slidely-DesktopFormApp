namespace SlidelyFormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnViewSubmissions = new Button();
            btnCreateSubmission = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnViewSubmissions
            // 
            btnViewSubmissions.BackColor = Color.CornflowerBlue;
            btnViewSubmissions.Location = new Point(208, 201);
            btnViewSubmissions.Name = "btnViewSubmissions";
            btnViewSubmissions.Size = new Size(324, 45);
            btnViewSubmissions.TabIndex = 0;
            btnViewSubmissions.Text = "View Submissions (CTRL + V)";
            btnViewSubmissions.UseVisualStyleBackColor = false;
            btnViewSubmissions.Click += btnViewSubmissions_Click;
            // 
            // btnCreateSubmission
            // 
            btnCreateSubmission.BackColor = Color.Khaki;
            btnCreateSubmission.ForeColor = SystemColors.ControlText;
            btnCreateSubmission.Location = new Point(208, 150);
            btnCreateSubmission.Name = "btnCreateSubmission";
            btnCreateSubmission.Size = new Size(324, 45);
            btnCreateSubmission.TabIndex = 1;
            btnCreateSubmission.Text = "Create New Submission (CTRL + N)";
            btnCreateSubmission.UseVisualStyleBackColor = false;
            btnCreateSubmission.Click += btnCreateSubmission_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 100);
            label1.Name = "label1";
            label1.Size = new Size(324, 20);
            label1.TabIndex = 2;
            label1.Text = "Abhijeet Singh,Slidely Task 2 - Slidely Form App";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCreateSubmission);
            Controls.Add(btnViewSubmissions);
            KeyPreview = true;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewSubmissions;
        private Button btnCreateSubmission;
        private Label label1;
    }
}
