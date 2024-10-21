using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Municipality_App;

namespace Municipality_App
{
    public partial class ViewIssuesForm : Form
    {
        private List<Issue> issues;  

        public ViewIssuesForm(List<Issue> issues)
        {
            InitializeComponent(); 
            this.issues = issues;  
        }

        private void ViewIssuesForm_Load(object sender, EventArgs e)
        {
            richTextBoxIssues.Clear(); 

            
            foreach (var issue in issues)
            {
                string issueDetails = $"Location: {issue.Location}\n" +
                                      $"Category: {issue.Category}\n" +
                                      $"Description: {issue.Description}\n" +
                                      $"Media Path: {issue.MediaPath}\n\n";

                richTextBoxIssues.AppendText(issueDetails);
            }
        }

        private void richTextBoxIssues_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there's a selection
            if (richTextBoxIssues.SelectedText.Contains("Media Path:"))
            {
                // Extract the media path from the selected text
                string selectedText = richTextBoxIssues.SelectedText;
                string mediaPath = ExtractMediaPath(selectedText);

                // Load the image if a valid path is found
                if (!string.IsNullOrEmpty(mediaPath) && File.Exists(mediaPath))
                {
                    pictureBoxIssue.Image = System.Drawing.Image.FromFile(mediaPath);
                }
                else
                {
                    pictureBoxIssue.Image = null; // Clear the PictureBox if no image is found
                }
            }
        }

        private string ExtractMediaPath(string text)
        {
            // Extract the media path from the provided text
            
            var parts = text.Split(new[] { "Media Path:" }, StringSplitOptions.None);
            if (parts.Length > 1)
            {
                return parts[1].Trim();
            }
            return string.Empty;
        }
    }

    
    
}
