using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipality_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            IssueReport report = new IssueReport();
            report.Show();
            this.Hide();
        }

        private void Annoucements_Click(object sender, EventArgs e)
        {
            AnnouncementAndEvents announcementAndEvents = new AnnouncementAndEvents();
            announcementAndEvents.Show();
            this.Hide();
        }
    }
}
