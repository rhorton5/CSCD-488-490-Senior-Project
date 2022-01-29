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
        //String filePath = getFileString();
        String filePath = "A String";
        MessageBox.Show("Work in progress... sending back to Specimen Format.");
        if (filePath != null)
        {
            //Program.filenameViewAll = filePath;
            Program.CurrentForm = new SpecimensForm();
            this.Close();
        }
        else
        {
            MessageBox.Show("An invalid file path was chosen, please try again...");
        }
    }

    private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (Program.CurrentForm.Name == this.Name)
        {
            Program.CurrentForm = null;
        }
    }

    private void BtnSpecimens_Click(object sender, EventArgs e)
    {
        Program.CurrentForm = new SpecimensForm();
        this.Close();
    }

    private void BtnTemplates_Click(object sender, EventArgs e)
    {
        Program.CurrentForm = new TemplatesForm();
        this.Close();
    }

    private void BtnSpecimensSummary_Click(object sender, EventArgs e)
    {
        Program.CurrentForm = new SpecimensSummaryForm();
        this.Close();
    }
}
