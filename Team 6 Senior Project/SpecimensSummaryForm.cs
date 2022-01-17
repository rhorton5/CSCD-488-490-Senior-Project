using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_6_Senior_Project
{
    //TODO: Set default start and end dates to specimen created min and max
    public partial class SpecimensSummaryForm : Form
    {
        public SpecimensSummaryForm()
        {
            InitializeComponent();
        }

        private void SpecimensSummaryForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewSpecimensSummary.DataSource = GetSummaryFromDataBase();

            // Style Totals row
            int lastRow = this.dataGridViewSpecimensSummary.Rows.GetLastRow(DataGridViewElementStates.Visible);
            this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
            this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.SelectionBackColor = Color.Red;
        }

        private DataTable GetSummaryFromDataBase()
        {
            String sqlStatement = $@"SELECT * FROM (SELECT Type, COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', AVG(Weight) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', STDEV(Weight) AS 'StDev Weight'
                                    FROM Specimens
                                    GROUP BY Type 
                                    UNION 
                                    SELECT '~Total~' AS 'Type', COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', AVG(Weight) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', STDEV(Weight) AS 'StDev Weight'
                                    FROM Specimens) AS temp 
                                    ORDER BY (CASE  WHEN Type LIKE '[a-Z][a-Z]%' THEN 0 ELSE 1 END)";

            DataTable dtSpecimens = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlStatement, con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtSpecimens.Load(reader);
                }
            }

            return dtSpecimens;
        }

        private DataTable GetSummaryWithDateRangeFromDataBase()
        {

            String startDate = DateTime.Parse(startDateDateTimePicker.Text).ToShortDateString();
            String endDate = DateTime.Parse(EndDateTimePicker.Text).ToShortDateString();
            String sqlStatement = $@"SELECT * FROM (SELECT Type, COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', AVG(Weight) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', STDEV(Weight) AS 'StDev Weight'
                                    FROM Specimens
                                    WHERE CAST(CreatedDate AS DATE) BETWEEN '{startDate}' AND '{endDate}' 
                                    GROUP BY Type 
                                    UNION 
                                    SELECT '~Total~' AS 'Type', COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', AVG(Weight) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', STDEV(Weight) AS 'StDev Weight'
                                    FROM Specimens
                                    WHERE CAST(CreatedDate AS DATE) BETWEEN '{startDate}' AND '{endDate}') AS temp 
                                    ORDER BY (CASE  WHEN Type LIKE '[a-Z][a-Z]%' THEN 0 ELSE 1 END)";

            DataTable dtSpecimens = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlStatement, con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtSpecimens.Load(reader);
                }
            }

            return dtSpecimens;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataGridViewSpecimensSummary.DataSource = GetSummaryFromDataBase();

            // Style Totals row
            int lastRow = this.dataGridViewSpecimensSummary.Rows.GetLastRow(DataGridViewElementStates.Visible);
            this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
            this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.SelectionBackColor = Color.Red;
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            this.dataGridViewSpecimensSummary.DataSource = GetSummaryWithDateRangeFromDataBase();

            // Style Totals row
            int lastRow = this.dataGridViewSpecimensSummary.Rows.GetLastRow(DataGridViewElementStates.Visible);
            this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
            this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.SelectionBackColor = Color.Red;
        }

        private void dataGridViewSpecimensSummary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void SpecimensSummaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Figure out how to bring back MainMenu, Ryley!
            if (Program.CurrentForm.Name == this.Name)
                Program.CurrentForm = null;
        }

        private void specimenDatabseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CurrentForm = new SpecimensForm();
            this.Close();
        }
        private void mainMenuDatabseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CurrentForm = new MainMenu();
            this.Close();
        }

        private void templatesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.CurrentForm = new TemplatesForm();
            this.Close();

        }
    }
}
