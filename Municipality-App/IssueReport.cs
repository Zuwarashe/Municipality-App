using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Municipality_App
{
    public partial class IssueReport : Form
    {
        private List<Issue> issues = new List<Issue>();
        private string mediaPath = string.Empty;

        public IssueReport()
        {
            InitializeComponent();
        }

        private void buttonAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Attach Media";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mediaPath = openFileDialog.FileName;
                    MessageBox.Show("Media attached successfully!", "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateIssueInput())
                {
                    Issue newIssue = new Issue
                    {
                        Location = textBoxLocation.Text.Trim(),
                        Category = comboBoxCategory.SelectedItem?.ToString(),
                        Description = richTextBoxDescription.Text.Trim(),
                        MediaPath = mediaPath
                    };

                    issues.Add(newIssue);
                    MessageBox.Show("Issue submitted successfully!", "Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting the issue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void buttonViewIssues_Click(object sender, EventArgs e)
        {
            try
            {
                if (issues.Count == 0)
                {
                    MessageBox.Show("No issues to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ViewIssuesForm viewForm = new ViewIssuesForm(issues);
                    viewForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while viewing issues: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateIssueInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxLocation.Text))
            {
                MessageBox.Show("Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
            {
                MessageBox.Show("Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            textBoxLocation.Clear();
            comboBoxCategory.SelectedIndex = -1;
            richTextBoxDescription.Clear();
            mediaPath = string.Empty;
        }

        private void labelLocation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
