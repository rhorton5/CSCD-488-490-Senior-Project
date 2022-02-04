namespace Team_6_Senior_Project;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private String GetFileString()
    {
        OpenFileDialog openFileDialog = new();
        openFileDialog.Filter = "csv files (*.csv)|*.csv";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        if (openFileDialog.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(openFileDialog.FileName))
        {
            return openFileDialog.FileName;
        }
        return null;
    }

    private void OpenExistingButton_Click(object sender, EventArgs e)
    {
        String filePath = GetFileString();
        if (filePath != null)
        {
            WindowSwapper.GoToSpecimensForm(this, filePath);
        }
    }

    private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
        WindowSwapper.ValidateWindow(this.Name);
    }

    private void BtnSpecimens_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToSpecimensForm(this);
    }

    private void BtnTemplates_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToTemplatesForm(this);
    }

    private void BtnSpecimensSummary_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToSpecimensSummaryForm(this);
    }
}
