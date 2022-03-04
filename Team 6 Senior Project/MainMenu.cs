namespace Team_6_Senior_Project;
using System.Data;

public partial class MainMenu : Form
{
    private WindowSwapper ws = new WindowSwapper();
    public MainMenu()
    {
        InitializeComponent();
    }

    private void OpenExistingButton_Click(object sender, EventArgs e)
    {
        OpenExistingOptionsForm optionsMenu = new OpenExistingOptionsForm();
        if (optionsMenu.ShowDialog() == DialogResult.OK)
        {
            string fileLocation = optionsMenu.GetSaveLocation();
            if (File.Exists(fileLocation))
            {
                DataTable csvDataTable = CSVFileManager.Import(fileLocation);
                ws.GoToSpecimensForm(this, csvDataTable);
            }
            
        }
        optionsMenu.Dispose();
    }

    private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
        WindowSwapper.ValidateWindow(Name);
    }

    private void BtnSpecimens_Click(object sender, EventArgs e)
    {
        ws.GoToSpecimensForm(this);
    }

    private void BtnTemplates_Click(object sender, EventArgs e)
    {
        ws.GoToTemplatesForm(this);
    }

    private void BtnSpecimensSummary_Click(object sender, EventArgs e)
    {
        ws.GoToSpecimensSummaryForm(this);
    }
}
