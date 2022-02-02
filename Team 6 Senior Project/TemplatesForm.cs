using System.Data;

namespace Team_6_Senior_Project;

public partial class TemplatesForm : Form
{

    // TODO: make it so it doesn't saved data when leaving row
    String OriginalType;
    String OriginalMaxWeight;
    String OriginalMinWeight;
    String OriginalNotes;
    String OriginalCreatedDate;
    String OriginalUpdatedDate;

    public TemplatesForm()
    {
        InitializeComponent();
    }

    private void TemplatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
        BtnSave_Click(sender, e);

    }

    private void TemplatesForm_Load(object sender, EventArgs e)
    {
        this.templatesTableAdapter.Fill(this.cSCDTeam6DataSet.Templates);

        this.createdDateDateTimePicker.Enabled = false;
        this.lastUpdatedDateTimePicker.Enabled = false;
    }

    private void TemplatesDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        OriginalType = typeTextBox.Text;
        OriginalMinWeight = minWeightTextBox.Text;
        OriginalMaxWeight = maxWeightTextBox.Text;
        OriginalNotes = notesTextBox.Text;
        OriginalCreatedDate = createdDateDateTimePicker.Text;
        OriginalUpdatedDate = lastUpdatedDateTimePicker.Text;
    }

    private void TemplatesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        try
        {
            String Message = "Are you sure you want to delete Type: " + typeTextBox.Text + "?";
            String Title = "Delete?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(Message, Title
                , buttons, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2); // Default to "no" not yes
            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

        }
        catch (Exception)
        {
        }
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            String Message = "Are you sure you want to delete Type: " + typeTextBox.Text + "?";
            String Title = "Delete?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(Message, Title
                , buttons, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2); // Default to "no" not yes
            if (dialogResult == DialogResult.Yes)
            {
                templatesBindingSource.RemoveCurrent();
            }
            else
            {
                return;
            }
        }
        catch (Exception)
        {
        }
    }

    private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
    {
        BtnDelete_Click(sender, e);
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            templatesBindingSource.AddNew();
            createdDateDateTimePicker.Text = DateTime.Now.ToString();
            lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

            typeTextBox.Focus();
        }
        catch (Exception)
        {
        }
    }

    private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
    {
        BtnAdd_Click(sender, e);
    }

    private Boolean IsUpdated()
    {
        // check if anything changed
        if (OriginalType != typeTextBox.Text ||
        OriginalMinWeight != minWeightTextBox.Text ||
        OriginalMaxWeight != maxWeightTextBox.Text ||
        OriginalNotes != notesTextBox.Text ||
        OriginalCreatedDate != createdDateDateTimePicker.Text ||
        OriginalUpdatedDate != lastUpdatedDateTimePicker.Text)
        {
            return true;
        }
        return false;
    }

    private static String SanatizeSQLString(String input)
    {
        // TODO: enhance security by also using SQL parmeters
        // https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?view=dotnet-plat-ext-6.0
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -

        while (input.Contains('>'))
        {
            input = input.Replace(">", "");
        }
        while (input.Contains('<'))
        {
            input = input.Replace("<", "");
        }
        while (input.Contains('\''))
        {
            input = input.Replace("'", "");
        }
        while (input.Contains('"'))
        {
            input = input.Replace("\"", "");
        }
        while (input.Contains(';'))
        {
            input = input.Replace(";", "");
        }
        while (input.Contains('-'))
        {
            input = input.Replace("-", "");
        }
        while (input.Contains('/'))
        {
            input = input.Replace("/", "");
        }
        while (input.Contains('*'))
        {
            input = input.Replace("*", "");
        }

        input = input.Trim();

        return input;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (!IsUpdated())
            {
                //no changed means no need to save
                return;
            }

            // Check for blanks: ID, type, weight, created, update
            // notes is allowed to be null
            if (typeTextBox.Text.Equals("") || minWeightTextBox.Text.Equals("") ||
                maxWeightTextBox.Text.Equals("") ||
                createdDateDateTimePicker.Text.Equals("") ||
                lastUpdatedDateTimePicker.Text.Equals("")
                )
            {
                MessageBox.Show("All fields but Notes are required. Please try again.");
                typeTextBox.Focus();
                return;
            }

            // check that notes length is <=255
            if (notesTextBox.Text.Length > 255)
            {
                MessageBox.Show("Notes max length of 255 characters. Please try again.");
                notesTextBox.Focus();
                return;
            }

            // check that type length is <=64
            if (typeTextBox.Text.Length > 64)
            {
                MessageBox.Show("Type max length of 64 characters. Please try again.");
                typeTextBox.Focus();
                return;
            }

            // Sanatize
            typeTextBox.Text = SanatizeSQLString(typeTextBox.Text);
            minWeightTextBox.Text = SanatizeSQLString(minWeightTextBox.Text);
            maxWeightTextBox.Text = SanatizeSQLString(maxWeightTextBox.Text);
            notesTextBox.Text = SanatizeSQLString(notesTextBox.Text);

            // Check for valid dates
            if (!DateTime.TryParse(createdDateDateTimePicker.Text, out DateTime createdDate))
            {
                MessageBox.Show("Invalid date given for Created Date. Please try again.");
                createdDateDateTimePicker.Focus();
                return;
            }

            if (!DateTime.TryParse(lastUpdatedDateTimePicker.Text, out DateTime lastUpdatedDate))
            {
                MessageBox.Show("Invalid date given for Created Date. Please try again.");
                lastUpdatedDateTimePicker.Focus();
                return;
            }

            // Check for valid date range. After 11/1/2021, less than or equal to now
            DateTime startDate = new(2021, 11, 1, 0, 0, 0);
            if (createdDate <= startDate || createdDate >= DateTime.Now)
            {
                MessageBox.Show("Invalid date given for Created Date. Please try again.");
                createdDateDateTimePicker.Focus();
                return;
            }
            if (lastUpdatedDate <= startDate || lastUpdatedDate >= DateTime.Now)
            {
                MessageBox.Show("Invalid date given for Created Date. Please try again.");
                lastUpdatedDateTimePicker.Focus();
                return;
            }

            // Check minweight is valid double
            if (!Double.TryParse(minWeightTextBox.Text, out double minWeight))
            {
                MessageBox.Show("Min Weight given outnot a valid number. Please try again.");
                minWeightTextBox.Focus();
                return;
            }
            // Check maxweight is valid double
            if (!Double.TryParse(maxWeightTextBox.Text, out double maxWeight))
            {
                MessageBox.Show("Max Weight given outnot a valid number. Please try again.");
                maxWeightTextBox.Focus();
                return;
            }

            // Force lastUpdatedDate to now
            lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

            this.Validate();
            this.templatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSCDTeam6DataSet);

        }
        catch (Exception)
        {
        }
    }

    private void MinWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Disallows all characters that are not controls digits or period "."
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }
        // Limits to only one period "."
        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }

    private void MaxWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Disallows all characters that are not controls digits or period "."
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }
        // Limits to only one period "."
        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }

    private void NotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -
        if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
        {
            e.Handled = true;
        }
    }

    private void TypeTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -
        if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void ToolStripTextSearchBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -
        if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
        {
            e.Handled = true;
        }
    }

    private void ToolStripButtonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            String combo = SanatizeSQLString(cmbDropDownList.Text);
            String search = SanatizeSQLString(toolStripTextSearchBox.Text);


            // TODO: Doesn't work for non-string fields? Check is sql doesn't use quotes for numbers
            string searchIndvidual = combo + " like '%" + search + "%'";
            templatesBindingSource.Filter = searchIndvidual;
        }
        catch (Exception)
        {
        }
    }

    private void ToolStripButtonClear_Click(object sender, EventArgs e)
    {
        templatesBindingSource.RemoveFilter();
        toolStripTextSearchBox.Clear();
    }

    private void MinWeightTextBox_TextChanged(object sender, EventArgs e)
    {
        // Check weight is valid double
        if (minWeightTextBox.Text == "")
        {
            return;
        }
        else if (!Double.TryParse(minWeightTextBox.Text, out double weight))
        {
            MessageBox.Show("Min Weight given not a valid number. Please try again.");
            minWeightTextBox.Focus();
            return;
        }
    }

    private void MaxWeightTextBox_TextChanged(object sender, EventArgs e)
    {
        // Check weight is valid double
        if (maxWeightTextBox.Text == "")
        {
            return;
        }
        else if (!Double.TryParse(maxWeightTextBox.Text, out double weight))
        {
            MessageBox.Show("Max Weight given not a valid number. Please try again.");
            minWeightTextBox.Focus();
            return;
        }
    }

    private void OpenToolStripButton_Click(object sender, EventArgs e)
    {
        CSVExporter.Export(this.templatesDataGridView);
    }

    private void TemplatesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.Cancel = true;
    }

    private void TemplatesForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        //TODO: Figure out how to bring back MainMenu, Ryley!
        if (IsUpdated() == false)
        {
            if (MessageBox.Show("You have some specimens that have not been saved yet to the database. Would you like to save?", "Confirm Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BtnSave_Click(sender, e);
            }
        }
        WindowSwapper.ValidateWindow(this.Name);
    }

    private void ToolStripButton1_Click(object sender, EventArgs e)
    {
        GoToMainMenuToolStripMenuItem_Click(sender, e);
    }

    private void SpecimensToolStripMenuItem_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToSpecimensForm(this);
    }

    private void SummaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToSpecimensSummaryForm(this);
    }

    private void GoToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        WindowSwapper.GoToMainMenu(this);
    }
}