using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityCharm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.Hide();

            EventsAnnouncementForm eventsAnnouncementForm = new EventsAnnouncementForm();
            eventsAnnouncementForm.Show();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            this.Hide();

            ServicesRequestForm serviceRequestForm = new ServicesRequestForm();
            serviceRequestForm.Show();
        }
    }
}
