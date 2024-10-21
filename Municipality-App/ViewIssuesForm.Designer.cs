namespace Municipality_App
{
    partial class ViewIssuesForm
    {
        private System.Windows.Forms.RichTextBox richTextBoxIssues;
        private System.Windows.Forms.PictureBox pictureBoxIssue;

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
            this.richTextBoxIssues = new System.Windows.Forms.RichTextBox();
            this.pictureBoxIssue = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CopyRights = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxIssues
            // 
            this.richTextBoxIssues.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxIssues.Name = "richTextBoxIssues";
            this.richTextBoxIssues.ReadOnly = true;
            this.richTextBoxIssues.Size = new System.Drawing.Size(500, 400);
            this.richTextBoxIssues.TabIndex = 0;
            this.richTextBoxIssues.Text = "";
            // 
            // pictureBoxIssue
            // 
            this.pictureBoxIssue.BackColor = System.Drawing.Color.White;
            this.pictureBoxIssue.Location = new System.Drawing.Point(518, 12);
            this.pictureBoxIssue.Name = "pictureBoxIssue";
            this.pictureBoxIssue.Size = new System.Drawing.Size(270, 400);
            this.pictureBoxIssue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIssue.TabIndex = 1;
            this.pictureBoxIssue.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empowering Every Citizen for a Better Tomorrow";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = global::Municipality_App.Properties.Resources.CityOfCapeTown_removebg_preview;
            this.pictureBox1.Image = global::Municipality_App.Properties.Resources.CityOfCapeTown_removebg_preview;
            this.pictureBox1.InitialImage = global::Municipality_App.Properties.Resources.CityOfCapeTown;
            this.pictureBox1.Location = new System.Drawing.Point(594, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CopyRights
            // 
            this.CopyRights.AutoSize = true;
            this.CopyRights.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyRights.Location = new System.Drawing.Point(27, 427);
            this.CopyRights.Name = "CopyRights";
            this.CopyRights.Size = new System.Drawing.Size(253, 14);
            this.CopyRights.TabIndex = 4;
            this.CopyRights.Text = "Copyright 2024 City of the Cape. All rights reserved";
            // 
            // ViewIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CopyRights);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxIssue);
            this.Controls.Add(this.richTextBoxIssues);
            this.Name = "ViewIssuesForm";
            this.Text = "View Reported Issues";
            this.Load += new System.EventHandler(this.ViewIssuesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CopyRights;
    }
}
