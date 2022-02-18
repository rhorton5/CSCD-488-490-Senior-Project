namespace Team_6_Senior_Project;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private static string GetFileString()
    {
        OpenFileDialog openFileDialog = new ();
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
        MessageBox.Show("Work in progress... sending back to Specimen Format.");
        
        string filePath = GetFileString();
        if (filePath != null)
        {
            WindowSwapper.GoToSpecimensFormWithCSV(this, filePath);
        }
        else
        {
            MessageBox.Show("An invalid file path was chosen, please try again...");
        }
        
    }

    private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
        WindowSwapper.ValidateWindow(Name);
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
