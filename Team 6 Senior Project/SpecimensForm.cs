using System.Collections;
using static Team_6_Senior_Project.SQLStatements;
using static Team_6_Senior_Project.DataValidation;
using static Team_6_Senior_Project.WindowSwapper;

namespace Team_6_Senior_Project;
public partial class SpecimensForm : Form
{
    bool DVGChanged { 
        get; 
        set; 
    }

    public SpecimensForm()
    {
        InitializeComponent();
        captureBtn.Visible = false;
    }

    public void LoadTable()
    {
        createdDateDateTimePicker.Enabled = false;
        lastUpdatedDateTimePicker.Enabled = false;
        specimensTableAdapter.Fill(cSCDTeam6DataSet.Specimens);
        ArrayList typesList = GetTemplatesTypes();
        cmbType.Items.AddRange(typesList.ToArray());
        DVGChanged = false;
    }

    private void SpecimensForm_Load(object sender, EventArgs e)
    {
        try
        {
            LoadTable();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    private void SpecimensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
        BtnSave_Click(sender, e);
    }


    private void BtnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            specimensBindingSource.AddNew();

            int id = SetSpecimenID();
            specimensIDTextBox.Text = id.ToString();
            int lastIndex = specimensDataGridView.Rows.Count;
            specimensDataGridView[0, lastIndex-1].Value = id;

            createdDateDateTimePicker.Text = DateTime.Now.ToString();
            lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

            cmbType.Focus();
            captureBtn.Visible = true;
        }
        catch (Exception)
        {
            int id = SetSpecimenID();
            specimensIDTextBox.Text = id.ToString();
            int lastIndex = specimensDataGridView.Rows.Count;
            specimensDataGridView[0, lastIndex-1].Value = id;

            createdDateDateTimePicker.Text = DateTime.Now.ToString();
            lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

            cmbType.Focus();
        }
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            string Message = "Are you sure you want to delete ID: " + specimensIDTextBox.Text + "?";
            string Title = "Delete?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(Message, Title,
                buttons, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2); // Default to "no" not yes
            if (dialogResult == DialogResult.Yes)
            {
                specimensBindingSource.RemoveCurrent();
                SaveTable();
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

    private void BtnSave_Click(object sender, EventArgs e)
    {
        try
        {
            //check if anything changed
            if (!IsUpdated())
            {
                //no changed means no need to save
                return;
            }


            // Check for blanks: ID, type, weight, created, update
            // notes is allowed to be null
            if (string.IsNullOrEmpty(specimensIDTextBox.Text) || string.IsNullOrEmpty(cmbType.Text) ||
                string.IsNullOrEmpty(weightTextBox.Text) || string.IsNullOrEmpty(createdDateDateTimePicker.Text) ||
                string.IsNullOrEmpty(lastUpdatedDateTimePicker.Text)
                )
            {
                MessageBox.Show("All fields but Notes are required. Please try again.");
                weightTextBox.Focus();
                return;
            }

            // Sanatize
            specimensIDTextBox.Text = SanatizeSQLString(specimensIDTextBox.Text);
            cmbType.Text = SanatizeSQLString(cmbType.Text);
            typeTextBox.Text = cmbType.Text;
            weightTextBox.Text = SanatizeSQLString(weightTextBox.Text);
            notesTextBox.Text = SanatizeSQLString(notesTextBox.Text);


            if (!ValidNotesRange(notesTextBox.Text))
            {
                MessageBox.Show("Notes max length of 255 characters. Please try again.");
                notesTextBox.Focus();
                return;
            }

            if (!ValidTypeRange(cmbType.Text))
            {
                MessageBox.Show("Type max length of 64 characters. Please try again.");
                cmbType.Focus();
                return;
            }

            if (!TypeIsInTemplate(cmbType.Text))
            {
                MessageBox.Show("Type not found in Templates. Please try again.");
                cmbType.Focus();
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
                MessageBox.Show("Invalid date given for Created Date. Please try again.");
                lastUpdatedDateTimePicker.Focus();
                return;
            }

            // Check weight is valid double
            if (!double.TryParse(weightTextBox.Text, out double weight))
            {
                MessageBox.Show("Weight given not a valid number. Please try again.");
                weightTextBox.Focus();
                return;
            }

            // Compare weight to template range
            if (!WeightIsInTemplateMinMax(cmbType.Text, weightTextBox.Text))
            {
                MessageBox.Show("Weight given not in template range for " + cmbType.Text + ". Min weight of: " + MinWeight(cmbType.Text) + ", Max weight of: " + MaxWeight(cmbType.Text) + ". Please try again.");
                weightTextBox.Focus();
                return;
            }
            captureBtn.Visible = false;
            SaveTable();
        }
        catch (Exception)
        {
            MessageBox.Show("Save failed, try again. Were all your entries valid?");
        }
    }

    private void SaveTable()
    {
        lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

        Validate();
        specimensBindingSource.EndEdit();
        tableAdapterManager.UpdateAll(cSCDTeam6DataSet);
        MessageBox.Show("Your Database has been saved!");
        DVGChanged = false;
    }

    private int SetSpecimenID()
    {
        int maxValue = -1;
        try
        {
            specimensBindingSource.RemoveFilter();
            toolStripTextSearchBox.Clear();

            for (int i = 0; i < specimensDataGridView.Rows.Count - 1; i++)
            {
                int id = int.Parse(specimensDataGridView.Rows[i].Cells[0].Value.ToString());
                if (id > maxValue)
                {
                    maxValue = id;
                }
            }
        }
        catch (Exception)
        {
        }
        return maxValue + 1;
    }

    private void FillByToolStripButton_Click(object sender, EventArgs e)
    {
        try
        {
            templatesTableAdapter.FillBy(cSCDTeam6DataSet.Templates);
        }
        catch (Exception)
        {
            MessageBox.Show("Database connection error. Please check network connection before contating admin or IT.");
        }
    }

    private void CmbType_SelectedValueChanged(object sender, EventArgs e)
    {
        typeTextBox.Text = cmbType.Text;
        updateSummary();
    }

    private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressNumeric(sender, e);
        DVGChanged = true;
    }

    private void NotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressNotes(sender, e);
        DVGChanged = true;
    }

    private void CmbType_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressSingleWord(sender, e);
        DVGChanged = true;
    }

    private void ToolStripButtonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string combo = SanatizeSQLString(cmbDropDownList.Text);
            string search = SanatizeSQLString(toolStripTextSearchBox.Text);

            // TODO: Doesn't work for non-string fields? Check is sql doesn't use quotes for numbers
            string searchIndvidual = combo + " like '%" + search + "%'";
            specimensBindingSource.Filter = searchIndvidual;
        }
        catch (Exception)
        {
        }
    }

    private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
    {
        BtnAdd_Click(sender, e);
    }

    private void SaveToolStripButton_Click(object sender, EventArgs e)
    {
        BtnSave_Click(sender, e);
    }

    private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
    {
        BtnDelete_Click(sender, e);
    }

    private void OpenToolStripExport_Click(object sender, EventArgs e)
    {
        CSVFileManager.Export(specimensDataGridView);
    }

    private void HomeButton_Click(object sender, EventArgs e)
    {
        GoToMainMenuToolStripMenuItem_Click(sender, e); //Initialized farther down in the code.
    }

    private void SpecimensForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (IsUpdated())
        {
            if (MessageBox.Show("You have some specimens that have not been saved yet to the database.  Would you like to save?", "Confirm Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BtnSave_Click(sender, e);
            }
        }

        ValidateWindow(Name);
    }

    private void ToolStripButtonClear_Click(object sender, EventArgs e)
    {
        specimensBindingSource.RemoveFilter();
        toolStripTextSearchBox.Clear();
    }

    private bool IsUpdated() // has changed
    {
        if (DVGChanged)
        {
            return true;
        }
        return false;
    }

    private void SpecimensDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        try
        {
            string Message = "Are you sure you want to delete ID: " + specimensIDTextBox.Text + "?";
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

    private void ToolStripTextSearchBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressNotes(sender, e);
    }

    private void WeightTextBox_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(weightTextBox.Text))
        {
            return;
        }
        else if (!double.TryParse(weightTextBox.Text, out double _))
        {
            MessageBox.Show("Weight given not a valid number. Please try again.");
            weightTextBox.Focus();
            return;
        }
    }

    private void SpecimensDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.Cancel = true;
    }

    private void TemplatesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        GoToTemplatesForm(this);
    }

    private void SummaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        GoToSpecimensSummaryForm(this);
    }

    private void GoToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        GoToMainMenu(this);
    }

    private void SpecimensDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
    {

        if (IsUpdated())
        {
            string Message = "You have unsaved data, would you like to save it? No will drop your changes.";
            string Title = "Save?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(Message, Title,
                buttons, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1); // Default to yes
            if (dialogResult == DialogResult.Yes)
            {
                BtnSave_Click(sender, e);
            }
            else
            {
                //ResetToOldValues();
                LoadTable();
            }
        }

    }

    private void captureBtn_Click(object sender, EventArgs e)
    {
        if (cmbType.Text == "")
        {
            cmbType.Focus();
        }
        else
        {
            Double minWeight = Convert.ToDouble(MinWeight(cmbType.Text));
            Double maxWeight = Convert.ToDouble(MaxWeight(cmbType.Text));
            Double capturedWeight = -1;
            Random random = new Random();
            try
            {
                while (capturedWeight < minWeight || capturedWeight > maxWeight)
                {
                    capturedWeight = random.NextDouble();
                    capturedWeight += random.Next((int)minWeight, (int)maxWeight);
                }
                weightTextBox.Text = capturedWeight.ToString();
            }
            catch (Exception) { }
        }
    }
    private void updateSummary()
    {
        string selectedType = cmbType.Text;
        string query = $@"SELECT COUNT(Weight) AS 'Count', SUM(Weight) AS 'Sum Weight', ROUND(AVG(Weight),4) AS 'Avg Weight', MIN(Weight) AS 'Min Weight', MAX(Weight) AS 'Max Weight', ROUND(STDEV(Weight),4) AS 'StDev Weight'
        FROM Specimens
        WHERE Type = '{selectedType}'";
        ArrayList selectedTypeSummary = GetArrayListWihSixColumns(query);

        labelTypeName.Text = "Type name: " + selectedType;
        labelTotalCount.Text = "Total count: " + selectedTypeSummary[0];
        labelTotalWeight.Text = "Total weight: " + selectedTypeSummary[1];
        labelMaxWeight.Text = "Max weight: " + selectedTypeSummary[4];
        labelMinWeight.Text = "Min weight: " + selectedTypeSummary[3];
        labelAverageWeight.Text = "Average weight: " + selectedTypeSummary[2];
        labelStdDeviation.Text = "Std Deviation: " + selectedTypeSummary[5];;
    }
}
