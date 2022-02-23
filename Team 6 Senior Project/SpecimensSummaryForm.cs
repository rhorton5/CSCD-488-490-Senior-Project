using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static Team_6_Senior_Project.SQLStatements;

namespace Team_6_Senior_Project;
// TODO: Set default start and end dates to specimen created min and max
public partial class SpecimensSummaryForm : Form
{
    WindowSwapper ws = new WindowSwapper();
    public SpecimensSummaryForm()
    {
        InitializeComponent();
    }

    private void SpecimensSummaryForm_Load(object sender, EventArgs e)
    {
        dataGridViewSpecimensSummary.DataSource = GetSummaryFromDataBase();

        // Style Totals row
        int lastRow = dataGridViewSpecimensSummary.Rows.GetLastRow(DataGridViewElementStates.Visible);
        dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
        dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.SelectionBackColor = Color.Red;
    }

    private static DataTable GetSummaryFromDataBase()
    {
        string query = $@"SELECT * 
                          FROM (SELECT Type, COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
                                FROM Specimens
                                GROUP BY Type 
                                UNION 
                                SELECT '~Total~' AS 'Type', COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
                                FROM Specimens) AS temp 
                                ORDER BY (CASE  WHEN Type LIKE '[a-Z][a-Z]%' THEN 0 ELSE 1 END)";


        return GetDataTableFromSelectStatement(query);
    }

    private DataTable GetSummaryWithDateRangeFromDataBase()
    {

        string startDate = DateTime.Parse(startDateDateTimePicker.Text).ToShortDateString();
        string endDate = DateTime.Parse(EndDateTimePicker.Text).ToShortDateString();
        string query = $@"SELECT * 
                          FROM (SELECT Type, COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
                                FROM Specimens
                                WHERE CAST(CreatedDate AS DATE) BETWEEN '{startDate}' AND '{endDate}' 
                                GROUP BY Type 
                                UNION 
                                SELECT '~Total~' AS 'Type', COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
                                FROM Specimens
                                WHERE CAST(CreatedDate AS DATE) BETWEEN '{startDate}' AND '{endDate}') AS temp 
                                ORDER BY (CASE  WHEN Type LIKE '[a-Z][a-Z]%' THEN 0 ELSE 1 END)";


        return GetDataTableFromSelectStatement(query);
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
        dataGridViewSpecimensSummary.DataSource = GetSummaryFromDataBase();
        StyleTotalsRow();
    }

    private void StyleTotalsRow()
    {
        int lastRow = dataGridViewSpecimensSummary.Rows.GetLastRow(DataGridViewElementStates.Visible);
        dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.BackColor = Color.Red;
        dataGridViewSpecimensSummary.Rows[lastRow].DefaultCellStyle.SelectionBackColor = Color.Red;
    }

    private void BtnSearchDate_Click(object sender, EventArgs e)
    {
        dataGridViewSpecimensSummary.DataSource = GetSummaryWithDateRangeFromDataBase();
        StyleTotalsRow();
    }

    private void DataGridViewSpecimensSummary_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.Cancel = true;
    }

    private void SpecimensSummaryForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        ws.ValidateWindow(Name);
    }

    private void SpecimenDatabseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ws.GoToSpecimensForm(this);
    }
    private void MainMenuDatabseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ws.GoToMainMenu(this);
    }

    private void TemplatesToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        ws.GoToTemplatesForm(this);
    }

    private void ExportStripButton_Click(object sender, EventArgs e)
    {
        CSVExporter.Export(dataGridViewSpecimensSummary);
    }
}