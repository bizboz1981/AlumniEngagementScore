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


        // method to browse to spreadsheet and load into datatable
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = openFileDialog.FileName;
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                using ExcelDataReader.IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream);
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
            
            // Parse datatable (spreadsheet) values to ints and calculate
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int age = Convert.ToInt32(row.Cells["Age"].Value);
                int amount = Convert.ToInt32(row.Cells["Donations"].Value);
                int consent = Convert.ToInt32(row.Cells["Consent"].Value);
                row.Cells["newColumnName"].Value = (age * ageFactor) + (donationFactor * amount) + (consent * consentFactor); //actual calculation
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
    }
}
