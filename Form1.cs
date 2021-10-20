using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AlumniEngagementScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        DataTableCollection tableCollection;
        readonly DataTable dt;


        // method to browse to spreadsheet and load into datatable
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = openFileDialog.FileName;
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                using var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                });
                tableCollection = result.Tables;
                cboSheet.Items.Clear();
                foreach (DataTable table in tableCollection)
                    cboSheet.Items.Add(table.TableName);//add sheet to combo box
            }
        }

        // 
        private void calculateScore()
        {
            // Parse input 'Factor' strings to ints
            int ageFactor = int.Parse(txtAgeFactor.Text);
            int donationFactor = int.Parse(txtDonationFactor.Text);
            int consentFactor = int.Parse(txtConsentFactor.Text);
            int optOutFactor = int.Parse(txtOptOutFactor.Text);
            int openFactor = int.Parse(txtOpenFactor.Text);
            int clickFactor = int.Parse(txtClickFactor.Text);
            int orgFactor = int.Parse(txtOrgFactor.Text);
            int positionFactor = int.Parse(txtPositionFactor.Text);
            int meetingsFactor = int.Parse(txtMeetingsFactor.Text);
            int emailFactor = int.Parse(txtEmailFactor.Text);
            int eventParticipationsFactor = int.Parse(txtEventsPartFactor.Text);
            int eventRegistrationsFactor = int.Parse(txtEventsRegFactor.Text);
            int updateDetailsFactor = int.Parse(txtUpdateDetailsFactor.Text);

            // Parse datatable (spreadsheet) values to ints and calculate
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //int age = Convert.ToInt32(row.Cells["Age"].Value);
                //int amount = Convert.ToInt32(row.Cells["Donations"].Value);
                int consent = Convert.ToInt32(row.Cells["Opt-In"].Value);
                int optOut = Convert.ToInt32(row.Cells["Opt-Out"].Value);
                int opens = Convert.ToInt32(row.Cells["Opened"].Value);
                int clicks = Convert.ToInt32(row.Cells["Clicked"].Value);
                int org = Convert.ToInt32(row.Cells["Primary Business Organisation"].Value);
                int position = Convert.ToInt32(row.Cells["Primary Business Position"].Value);
                int meetings = Convert.ToInt32(row.Cells["Number of Meetings"].Value);
                int email = Convert.ToInt32(row.Cells["Email 1 Number"].Value);
                int eventParticipations = Convert.ToInt32(row.Cells["Event Participations"].Value);
                int eventRegistrations = Convert.ToInt32(row.Cells["Event Registrations"].Value);
                int updateDetails = Convert.ToInt32(row.Cells["Update Details"].Value);

                //actual calculation
                row.Cells["newColumnName"].Value =  (consent * consentFactor)+
                                                    (optOut * optOutFactor)+
                                                    (opens * openFactor)+
                                                    (clicks * clickFactor)+
                                                    (org * orgFactor)+
                                                    (position * positionFactor)+
                                                    (meetings * meetingsFactor)+
                                                    (email * emailFactor)+
                                                    (eventParticipations * eventParticipationsFactor)+
                                                    (eventRegistrations * eventRegistrationsFactor)+
                                                    (updateDetails * updateDetailsFactor); 
            }
        }
        
        // 'Click' Method invoked when you click 'Calculate Score'
        private void btnCalcScore_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("newColumnName", "Score"); // add a new column called 'Score'
            calculateScore(); //call the previously defined method
            btnCalcScore.Visible = false; //hide 'Caluculate'
            btnRecalculate.Visible = true; //show 'Recalculate'
        }

        private void btnRecalculate_Click(object sender, EventArgs e)
        {
            calculateScore();
        }
        

        private void btnToCSV_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV (*.csv)|*.csv",
                    FileName = "Output.csv"
                };
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
