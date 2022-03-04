namespace Team_6_Senior_Project;

using static Team_6_Senior_Project.DataValidation;

public partial class TemplatesForm : Form
{

    // TODO: make it so it doesn't saved data when leaving row
    string OriginalType;
    string OriginalMaxWeight;
    string OriginalMinWeight;
    string OriginalNotes;
    string OriginalCreatedDate;
    string OriginalUpdatedDate;

    WindowSwapper ws = new WindowSwapper();

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
        templatesTableAdapter.Fill(this.cSCDTeam6DataSet.Templates);

        createdDateDateTimePicker.Enabled = false;
        lastUpdatedDateTimePicker.Enabled = false;
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
            string Message = "Are you sure you want to delete Type: " + typeTextBox.Text + "?";
            string Title = "Delete?";
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
            string Message = "Are you sure you want to delete Type: " + typeTextBox.Text + "?";
            string Title = "Delete?";
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
            if (string.IsNullOrEmpty(typeTextBox.Text) || string.IsNullOrEmpty(minWeightTextBox.Text) ||
                string.IsNullOrEmpty(maxWeightTextBox.Text) ||
                string.IsNullOrEmpty(createdDateDateTimePicker.Text) ||
                string.IsNullOrEmpty(lastUpdatedDateTimePicker.Text)
                )
            {
                MessageBox.Show("All fields but Notes are required. Please try again.");
                typeTextBox.Focus();
                return;
            }

            // Sanatize
            typeTextBox.Text = SanatizeSQLString(typeTextBox.Text);
            minWeightTextBox.Text = SanatizeSQLString(minWeightTextBox.Text);
            maxWeightTextBox.Text = SanatizeSQLString(maxWeightTextBox.Text);
            notesTextBox.Text = SanatizeSQLString(notesTextBox.Text);

            if (!ValidNotesRange(notesTextBox.Text))
            {
                MessageBox.Show("Notes max length of 255 characters. Please try again.");
                notesTextBox.Focus();
                return;
            }

            // check that type length is <=64
            if (!ValidTypeRange(typeTextBox.Text))
            {
                MessageBox.Show("Type max length of 64 characters. Please try again.");
                typeTextBox.Focus();
                return;
            }

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

            if (!ValidDateRange(createdDate))
            {
                MessageBox.Show("Invalid date given for Created Date. Please try again.");
                createdDateDateTimePicker.Focus();
                return;
            }
            if (!ValidDateRange(lastUpdatedDate))
            {
                MessageBox.Show("Invalid date given for Last Updated Date. Please try again.");
                lastUpdatedDateTimePicker.Focus();
                return;
            }

            // Check minweight is valid double
            if (!double.TryParse(minWeightTextBox.Text, out double minWeight))
            {
                MessageBox.Show("Min Weight given not a valid number. Please try again.");
                minWeightTextBox.Focus();
                return;
            }
            // Check maxweight is valid double
            if (!double.TryParse(maxWeightTextBox.Text, out double maxWeight))
            {
                MessageBox.Show("Max Weight given not a valid number. Please try again.");
                maxWeightTextBox.Focus();
                return;
            }

            // Force lastUpdatedDate to now
            lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

            Validate();
            templatesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cSCDTeam6DataSet);

        }
        catch (Exception)
        {
        }
    }

    private void MinWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressNumeric(sender, e);
    }

    private void MaxWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressNumeric(sender, e);
    }

    private void NotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressNotes(sender, e);
    }

    private void TypeTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressSingleWord(sender, e);
    }

    private void ToolStripTextSearchBox_KeyPress(object sender, KeyPressEventArgs e)
    {
KeyPressNotes(sender, e);
    }

    private void ToolStripButtonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string combo = SanatizeSQLString(cmbDropDownList.Text);
            string search = SanatizeSQLString(toolStripTextSearchBox.Text);


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
        if (string.IsNullOrEmpty(minWeightTextBox.Text))
        {
            return;
        }
        else if (!double.TryParse(minWeightTextBox.Text, out double _))
        {
            MessageBox.Show("Min Weight given not a valid number. Please try again.");
            minWeightTextBox.Focus();
            return;
        }
    }

    private void MaxWeightTextBox_TextChanged(object sender, EventArgs e)
    {
        // Check weight is valid double
        if (string.IsNullOrEmpty(maxWeightTextBox.Text))
        {
            return;
        }
        else if (!double.TryParse(maxWeightTextBox.Text, out double _))
        {
            MessageBox.Show("Max Weight given not a valid number. Please try again.");
            minWeightTextBox.Focus();
            return;
        }
    }

    private void OpenToolStripButton_Click(object sender, EventArgs e)
    {
        CSVFileManager.Export(templatesDataGridView);
    }

    private void TemplatesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.Cancel = true;
    }

    private void TemplatesForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (IsUpdated() == false)
        {
            if (MessageBox.Show("You have some specimens that have not been saved yet to the database. Would you like to save?", "Confirm Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BtnSave_Click(sender, e);
            }
        }
        WindowSwapper.ValidateWindow(Name);
    }

    private void ToolStripButton1_Click(object sender, EventArgs e)
    {
        GoToMainMenuToolStripMenuItem_Click(sender, e);
    }

    private void SpecimensToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ws.GoToSpecimensForm(this);
    }

    private void SummaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ws.GoToSpecimensSummaryForm(this);
    }

    private void GoToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ws.GoToMainMenu(this);
    }
}