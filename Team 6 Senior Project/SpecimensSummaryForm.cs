using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Team_6_Senior_Project;
// TODO: Set default start and end dates to specimen created min and max
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

    private static DataTable GetSummaryFromDataBase()
    {
        String sqlStatement = $@"SELECT * FROM (SELECT Type, COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
                                    FROM Specimens
                                    GROUP BY Type 
                                    UNION 
                                    SELECT '~Total~' AS 'Type', COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
                                    FROM Specimens) AS temp 
                                    ORDER BY (CASE  WHEN Type LIKE '[a-Z][a-Z]%' THEN 0 ELSE 1 END)";

        DataTable dtSpecimens = new();

        string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;

        using (SqlConnection con = new(connString))
        {
            using SqlCommand cmd = new(sqlStatement, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            dtSpecimens.Load(reader);
        }

        return dtSpecimens;
    }

    private DataTable GetSummaryWithDateRangeFromDataBase()
    {

        String startDate = DateTime.Parse(startDateDateTimePicker.Text).ToShortDateString();
        String endDate = DateTime.Parse(EndDateTimePicker.Text).ToShortDateString();
        String sqlStatement = $@"SELECT * FROM (SELECT Type, COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
                                    FROM Specimens
                                    WHERE CAST(CreatedDate AS DATE) BETWEEN '{startDate}' AND '{endDate}' 
                                    GROUP BY Type 
                                    UNION 
                                    SELECT '~Total~' AS 'Type', COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
                                    FROM Specimens
                                    WHERE CAST(CreatedDate AS DATE) BETWEEN '{startDate}' AND '{endDate}') AS temp 
                                    ORDER BY (CASE  WHEN Type LIKE '[a-Z][a-Z]%' THEN 0 ELSE 1 END)";

        DataTable dtSpecimens = new();

        string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;

        using (SqlConnection con = new(connString))
        {
            using SqlCommand cmd = new(sqlStatement, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            dtSpecimens.Load(reader);
        }

        return dtSpecimens;
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
        this.dataGridViewSpecimensSummary.DataSource = GetSummaryFromDataBase();

        // Style Totals row
        int lastRow = this.dataGridViewSpecimensSummary.Rows.GetLastRow(DataGridViewElementStates.Visible);
        this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
        this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.SelectionBackColor = Color.Red;
    }

    private void BtnSearchDate_Click(object sender, EventArgs e)
    {
        this.dataGridViewSpecimensSummary.DataSource = GetSummaryWithDateRangeFromDataBase();

        // Style Totals row
        int lastRow = this.dataGridViewSpecimensSummary.Rows.GetLastRow(DataGridViewElementStates.Visible);
        this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
        this.dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.SelectionBackColor = Color.Red;
    }

    private void DataGridViewSpecimensSummary_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.Cancel = true;
    }

    private void SpecimensSummaryForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        WindowSwapper.ValidateWindow(this.Name);
    }

    private void SpecimenDatabseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToSpecimensForm(this);
    }
    private void MainMenuDatabseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToMainMenu(this);
    }

    private void TemplatesToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToTemplatesForm(this);
    }

    private void exportStripButton_Click(object sender, EventArgs e)
    {
        CSVExporter.Export(this.dataGridViewSpecimensSummary);
    }
}