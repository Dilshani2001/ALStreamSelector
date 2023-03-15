using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AdvancedLevelStreamSelector
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> streamIDs = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Students_Details' table. You can move, or remove it, as needed.
            this.students_DetailsTableAdapter.Fill(this.dbDataSet.Students_Details);
            // TODO: This line of code loads data into the 'dbDataSet.Stream_Weights' table. You can move, or remove it, as needed.
            this.stream_WeightsTableAdapter.Fill(this.dbDataSet.Stream_Weights);
            // TODO: This line of code loads data into the 'dbDataSet.Stream_Details' table. You can move, or remove it, as needed.
            this.stream_DetailsTableAdapter.Fill(this.dbDataSet.Stream_Details);
            // TODO: This line of code loads data into the 'dbDataSet.School_Details' table. You can move, or remove it, as needed.
            this.school_DetailsTableAdapter.Fill(this.dbDataSet.School_Details);
            // TODO: This line of code loads data into the 'dbDataSet.Result_Details' table. You can move, or remove it, as needed.
            this.result_DetailsTableAdapter.Fill(this.dbDataSet.Result_Details);
            // TODO: This line of code loads data into the 'dbDataSet.Points_Table' table. You can move, or remove it, as needed.
            this.points_TableTableAdapter.Fill(this.dbDataSet.Points_Table);

            var streams = stream_DetailsTableAdapter.GetData().Select();
            foreach (DataRow x in streams)
            {
                this.cmbStream.Items.Add(x["Stream Name"].ToString());
                this.streamIDs.Add(x["Stream Name"].ToString(), Convert.ToInt32(x["ID"].ToString()));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIndexNo.Text == "" || cmbStream.Text == "")
            {
                MessageBox.Show("Please enter index unmber and select a stream to continue!");
            }
            else
            {
                // Get index number
                var indexNo = Convert.ToInt32(txtIndexNo.Text);

                // Get selected stream
                var stream = cmbStream.Text;

                // Get all subject names
                List<string> subjects = new List<string>();
                foreach (DataColumn column in dbDataSet.Result_Details.Columns)
                {
                    subjects.Add(column.ColumnName);
                }

                var results = result_DetailsTableAdapter.GetData().Select($"IndexNumber = {indexNo}");
                if (results.Length > 0)
                {
                    Dictionary<string, int> resultMap = new Dictionary<string, int>();
                    Dictionary<string, string> resultDisplayMap = new Dictionary<string, string>();


                    // Calculate points for each result
                    foreach (string subject in subjects)
                    {
                        if (subject != "IndexNumber")
                        {
                            // Remove spaces in subject names and caonvert to lower case
                            string key = Regex.Replace(subject, @"\s+", "").ToLower();
                            string pass = results[0][subject].ToString();
                            if (pass != "")
                            {
                                var pointDetails = points_TableTableAdapter.GetData().Select($"Pass = '{pass}'");
                                resultMap.Add(key, Convert.ToInt32(pointDetails[0]["Points"].ToString()));
                                resultDisplayMap.Add(subject, pass);
                            }
                        }
                    }

                    try {
                        var selectedStreamId = this.streamIDs[cmbStream.Text];

                        // Find pass mark for the selected stream
                        var selectedStreamDetails = stream_DetailsTableAdapter.GetData().Select($"ID = {selectedStreamId}");
                        var passMark = Convert.ToInt32(selectedStreamDetails[0]["Pass Mark"].ToString());

                        // Find stream weights for selected stream
                        var weightDetails = stream_WeightsTableAdapter.GetData().Select($"Stream = {selectedStreamId}");
                        Dictionary<string, int> streamWeightsMap = new Dictionary<string, int>();
                        foreach (DataRow x in weightDetails)
                        {
                            String key = Regex.Replace(x["Subject"].ToString(), @"\s+", "").ToLower(); x["Subject"].ToString();
                            streamWeightsMap.Add(key, Convert.ToInt32(x["Weight"].ToString()));
                        }

                        // Calculate score for the student
                        int score = 0;
                        foreach (KeyValuePair<string, int> ele in resultMap)
                        {
                            score += ele.Value * streamWeightsMap[ele.Key];
                        }

                        // Display Output
                        txtSelectedStream.Text = cmbStream.Text;
                        txtStreamPassMark.Text = passMark.ToString();
                        txtStudentScore.Text = score.ToString();
                        if (passMark <= score)
                        {
                            txtEligibility.Text = "Eligible";
                            txtEligibility.ForeColor = Color.Green;
                        }
                        else
                        {
                            txtEligibility.Text = "Not Eligible";
                            txtEligibility.ForeColor = Color.Red;
                        }

                        foreach (KeyValuePair<string, string> ele in resultDisplayMap)
                        {
                            txtResult.Text += $"{ele.Key} : {ele.Value}{Environment.NewLine}";
                        }
                    }
                    catch (KeyNotFoundException)
                    {
                        MessageBox.Show("You have entered an unknowd stream. Please check and try again");
                    }
                }
                else
                {
                    MessageBox.Show("Index number not found in database");
                }
            }
        }
    }
}
