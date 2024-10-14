using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityCharm
{
    public partial class ReportIssuesForm : Form
    {
        DBAccess dbAccess = new DBAccess();

        private int locationStopper = 0;
        private int categoryStopper = 0;
        private int descriptionStopper = 0;
        private int imgStopper = 0;

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            dpDate.Text = DateTime.Now.ToLongDateString();

            prgssProgress.Value = 0;
            
            if (dpDate.Value != null)
            {
                prgssProgress.Value = prgssProgress.Value + 20;
            }
            
            if (imgFile.Image.ToString() != null)
            {
                prgssProgress.Value = prgssProgress.Value + 20;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string location;
            string category;
            string date;
            byte[] attachment;
            string description;


            try
            {
                //Declaration
                location = txtLocation.Text;
                category = drpCategory.Text;
                date = dpDate.Value.ToShortDateString();
                description = rTxtDescription.Text;
                attachment = GetImage();

                //Validation
                if (location.Equals(""))
                {
                    MessageBox.Show("Please enter the location");
                    txtLocation.Focus();
                }
                else if (category.Equals(""))
                {
                    MessageBox.Show("Please select the category");
                    drpCategory.Focus();
                }
                else if (dpDate.Value < DateTime.Today)
                {
                    MessageBox.Show("Please select valid date");
                    dpDate.Focus();
                }
                else if (description.Equals(""))
                {
                    MessageBox.Show("Please enter description of the problem");
                    rTxtDescription.Focus();
                }
                else
                {
                    //Storing into a list
                    List<ReportIssues> issues = new List<ReportIssues>();

                    ReportIssues reportIssues = new ReportIssues(location, category, date, attachment, description);
                    issues.Add(reportIssues);

                    foreach (ReportIssues issue in issues) 
                    {
                        MessageBox.Show("--Reports-- \nLocation: " + issue.location+ "\nCategory: " + issue.category+ "\nDate: " + issue.date+ "\nAttachment: " + issue.attachment+ "\nDescription: " + issue.description);

                    }

                    //SQL query string to be used for inserting data into the database
                    string query = "INSERT INTO report_issues(location, category, date, attachment, description) values(@location, @category, @date, @attachment, @description)";
                    SqlCommand sqlCommand = new SqlCommand(query);

                    sqlCommand.Parameters.AddWithValue("@location", location);
                    sqlCommand.Parameters.AddWithValue ("@category", category);
                    sqlCommand.Parameters.AddWithValue("@date", date);
                    sqlCommand.Parameters.AddWithValue("@attachment", attachment);
                    sqlCommand.Parameters.AddWithValue("@description", description);

                    int insertRow = dbAccess.executeQuery(sqlCommand);

                    if (insertRow > 0) 
                    {
                        MessageBox.Show("Report submitted successfully.");

                        //Redirect
                        this.Hide();

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Report submission failed, Try again!");
                    }

                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //Get image in byte format
        private byte[] GetImage()
        {
            MemoryStream stream = new MemoryStream();
            imgFile.Image.Save(stream, imgFile.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void imgFile_Click(object sender, EventArgs e)
        {
            //For user to be able to add image
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgFile.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //For user to be able to add image
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgFile.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            //For progress bar increment and decrement
            if (txtLocation.Text.Length > 0)
            {
                if (prgssProgress.Value != 100)
                {
                    if (locationStopper != 1)
                    {
                        locationStopper++;
                        prgssProgress.Value = prgssProgress.Value + 20;
                    }
                }
            }
            else
            {
                if (prgssProgress.Value != 0)
                {
                    prgssProgress.Value = prgssProgress.Value - 20;
                }
                locationStopper = 0;
            }
        }

        private void drpCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //For progress bar increment and decrement
            if (!drpCategory.Text.Equals(""))
            {
                if (prgssProgress.Value != 100)
                {
                    if (categoryStopper != 1)
                    {
                        categoryStopper++;
                        prgssProgress.Value = prgssProgress.Value + 20;
                    }
                }
            }
            else
            {
                if (prgssProgress.Value != 0)
                {
                    prgssProgress.Value = prgssProgress.Value - 20;
                }

            }
        }

        private void rTxtDescription_TextChanged(object sender, EventArgs e)
        {
            //For progress bar increment and decrement
            if (rTxtDescription.Text.Length > 0)
            {
                if (prgssProgress.Value != 100)
                {
                    if (descriptionStopper != 1)
                    {
                        descriptionStopper++;
                        prgssProgress.Value = prgssProgress.Value + 20;
                    }
                }
            }
            else
            {
                if (prgssProgress.Value != 0)
                {
                    prgssProgress.Value = prgssProgress.Value - 20;
                }
                descriptionStopper = 0;
            }
        }
    }
}
