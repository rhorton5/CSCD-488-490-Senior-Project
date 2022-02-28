﻿using System.Collections;
using static Team_6_Senior_Project.SQLStatements;
using static Team_6_Senior_Project.DataValidation;
using static Team_6_Senior_Project.WindowSwapper;

namespace Team_6_Senior_Project;
public partial class SpecimensForm : Form
{
    string OriginalSpecimenID;
    string OriginalType;
    string OriginalWeight;
    string OriginalNotes;
    string OriginalCreatedDate;
    string OriginalUpdatedDate;
    string FileLocationName;

    WindowSwapper ws = new WindowSwapper();

    public SpecimensForm()
    {
        InitializeComponent();
    }

    public SpecimensForm(string csvData)
    {
        InitializeComponent();
        FileLocationName = csvData;
        string[] rows = csvData.Split("\n");
        System.Data.DataTable dt = new System.Data.DataTable("Importing Item");
        foreach(string str in rows[0].Split(","))
        {
            dt.Columns.Add(str);
        }
        for(int i = 1; i < rows.Length; i++)
        {
            System.Data.DataRow dataRow = dt.NewRow();
            dataRow.ItemArray = rows[i].Split(",");
            dt.Rows.Add(dataRow);
        }
        dt = removeInvalidRows(dt);
    }

    private System.Data.DataTable removeInvalidRows(System.Data.DataTable dt)
    {
        System.Data.DataTable res = dt;
        ArrayList typesList = GetTemplatesTypes();  //Called here to avoid multiple calls.
        ArrayList RowsToRemove = new ArrayList();
        foreach(System.Data.DataRow dr in dt.Rows)
        {
            
            string specimenID = dr.ItemArray[0].ToString();
            string type = dr.ItemArray[1].ToString();
            string weight = dr.ItemArray[2].ToString();
            DateTime createdDate, lastCreatedDate;
            try
            {
                createdDate = DateTime.Parse(dr.ItemArray[4].ToString());
                lastCreatedDate = DateTime.Parse(dr.ItemArray[5].ToString());
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("DateTime(s) Created An Error -> Row Deleted!");
                RowsToRemove.Add(dr);
                break;
            }
            
            string notes = SanatizeSQLString(dr.ItemArray[3].ToString());
            
            if(!typesList.Contains(type) || !WeightIsInTemplateMinMax(type,weight) || !ValidNotesRange(notes) 
                || !ValidDateRange(lastCreatedDate) || !ValidDateRange(createdDate))
            {
                RowsToRemove.Add(dr);
                System.Diagnostics.Debug.WriteLine("Row Deleted!");

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Row Saved!");
            }
        }
        foreach(System.Data.DataRow dr in RowsToRemove)
        {
            res.Rows.Remove(dr);
        }
        return res;
    }

    private void SpecimensForm_Load(object sender, EventArgs e)
    {
        try
        {
            createdDateDateTimePicker.Enabled = false;
            lastUpdatedDateTimePicker.Enabled = false;
            specimensTableAdapter.Fill(cSCDTeam6DataSet.Specimens);
            ArrayList typesList = GetTemplatesTypes();
            cmbType.Items.AddRange(typesList.ToArray());
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
            specimensIDTextBox.Text = SetSpecimenID().ToString();
            createdDateDateTimePicker.Text = DateTime.Now.ToString();
            lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

            typeTextBox.Focus();
        }
        catch (Exception)
        {
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

            // Force lastUpdatedDate to now
            lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

            Validate();
            specimensBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cSCDTeam6DataSet);
            MessageBox.Show("Your Database has been saved!");
        }
        catch (Exception)
        {
            MessageBox.Show("Save failed, try again. Were all your entries valid?");
        }
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
    }

    private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressNumeric(sender, e);
    }

    private void NotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressNotes(sender, e);
    }

    private void CmbType_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyPressSingleWord(sender, e);
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
        if (IsUpdated() == false)
        {
            if (MessageBox.Show("You have some specimens that have not been saved yet to the database.  Would you like to save?", "Confirm Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BtnSave_Click(sender, e);
            }
        }

        ws.ValidateWindow(Name);
    }

    private void ToolStripButtonClear_Click(object sender, EventArgs e)
    {
        specimensBindingSource.RemoveFilter();
        toolStripTextSearchBox.Clear();
    }

    private bool IsUpdated()
    {
        if (OriginalSpecimenID != specimensIDTextBox.Text ||
        OriginalType != typeTextBox.Text ||
        OriginalWeight != weightTextBox.Text ||
        OriginalNotes != notesTextBox.Text ||
        OriginalCreatedDate != createdDateDateTimePicker.Text ||
        OriginalUpdatedDate != lastUpdatedDateTimePicker.Text)
        {
            return true;
        }
        return false;
    }

    private void SpecimensDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        OriginalSpecimenID = specimensIDTextBox.Text;
        OriginalType = typeTextBox.Text;
        OriginalWeight = weightTextBox.Text;
        OriginalNotes = notesTextBox.Text;
        OriginalCreatedDate = createdDateDateTimePicker.Text;
        OriginalUpdatedDate = lastUpdatedDateTimePicker.Text;
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
        ws.GoToTemplatesForm(this);
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
