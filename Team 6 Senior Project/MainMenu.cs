namespace Team_6_Senior_Project;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }
    private void OpenExistingButton_Click(object sender, EventArgs e)
    {
        using(OpenFileDialog dialog = new OpenFileDialog())
        {
            dialog.Filter = "CSV Files (*.csv) | *.*";
            dialog.Title = "Open Existing";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckFileExists) 
            {
                OpenExistingOptionsMenu openExistingOptionsMenu = new OpenExistingOptionsMenu(dialog.FileName);
                if(openExistingOptionsMenu.ShowDialog() == DialogResult.OK)
                    WindowSwapper.GoToSpecimensForm(this);
                openExistingOptionsMenu.Close();
            }
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
