namespace Municipality_App
{
    partial class IssueReport
    {
      
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonAttachMedia;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonViewIssues;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDescription;
       // private string mediaPath = string.Empty; // To store media file path

        private void InitializeComponent()
        {
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonAttachMedia = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonViewIssues = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLocation.Location = new System.Drawing.Point(52, 185);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocation.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.comboBoxCategory.Location = new System.Drawing.Point(442, 185);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(178, 242);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(200, 100);
            this.richTextBoxDescription.TabIndex = 2;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonAttachMedia
            // 
            this.buttonAttachMedia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAttachMedia.Location = new System.Drawing.Point(246, 348);
            this.buttonAttachMedia.Name = "buttonAttachMedia";
            this.buttonAttachMedia.Size = new System.Drawing.Size(100, 23);
            this.buttonAttachMedia.TabIndex = 3;
            this.buttonAttachMedia.Text = "Attach Media";
            this.buttonAttachMedia.UseVisualStyleBackColor = false;
            this.buttonAttachMedia.Click += new System.EventHandler(this.buttonAttachMedia_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSubmit.Location = new System.Drawing.Point(164, 386);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(457, 430);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(150, 23);
            this.buttonBackToMainMenu.TabIndex = 5;
            this.buttonBackToMainMenu.Text = "Back to Main Menu";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonViewIssues
            // 
            this.buttonViewIssues.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonViewIssues.Location = new System.Drawing.Point(319, 386);
            this.buttonViewIssues.Name = "buttonViewIssues";
            this.buttonViewIssues.Size = new System.Drawing.Size(100, 23);
            this.buttonViewIssues.TabIndex = 6;
            this.buttonViewIssues.Text = "View Issues";
            this.buttonViewIssues.UseVisualStyleBackColor = false;
            this.buttonViewIssues.Click += new System.EventHandler(this.buttonViewIssues_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(61, 155);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(51, 13);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Location:";
            this.labelLocation.Click += new System.EventHandler(this.labelLocation_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(439, 155);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(49, 242);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 47);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright 2024 City of the Cape. All rights reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Municipality_App.Properties.Resources.CityOfCapeTown_removebg_preview;
            this.pictureBox1.Image = global::Municipality_App.Properties.Resources.CityOfCapeTown_removebg_preview;
            this.pictureBox1.InitialImage = global::Municipality_App.Properties.Resources.CityOfCapeTown;
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(1, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 47);
            this.panel2.TabIndex = 9;
            // 
            // IssueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.buttonAttachMedia);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonViewIssues);
            this.Name = "IssueReport";
            this.Text = "Issue Report Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}
