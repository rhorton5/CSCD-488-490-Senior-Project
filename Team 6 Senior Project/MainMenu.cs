namespace Team_6_Senior_Project;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }
    /*
    private static string GetFileString()
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
    */
    private void OpenExistingButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Work in progress... sending back to Specimen Format.");
        /*
        //string filePath = getFileString();
        string filePath = "A String";
        if (filePath != null)
        {
            //Program.filenameViewAll = filePath;
            BtnSpecimens_Click(sender, e);
        }
        else
        {
            MessageBox.Show("An invalid file path was chosen, please try again...");
        }
        */
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
