using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace Team_6_Senior_Project;
public partial class SpecimensForm : Form
{
    String OriginalSpecimenID;
    String OriginalType;
    String OriginalWeight;
    String OriginalNotes;
    String OriginalCreatedDate;
    String OriginalUpdatedDate;
    String FileLocationName = null;

    public SpecimensForm()
    {
        InitializeComponent();
    }

    public SpecimensForm(String filename)
    {
        InitializeComponent();
        this.FileLocationName = filename;
    }
    private void SpecimensForm_Load(object sender, EventArgs e)
    {
        try
        {
            this.createdDateDateTimePicker.Enabled = false;
            this.lastUpdatedDateTimePicker.Enabled = false;
            this.specimensTableAdapter.Fill(this.cSCDTeam6DataSet.Specimens);
            ArrayList typesList = GetTypes();
            this.cmbType.Items.AddRange(typesList.ToArray());
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }


    private String MinWeight()
    {

        String minWeight = "";
        String type = cmbType.Text;

        try
        {
            String query = $@"SELECT MinWeight 
                              FROM Templates WHERE Type = '{type}'";

            String connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
            SqlConnection connection = new(connString);
            connection.Open();
            SqlCommand command = new(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                minWeight += dataReader[0].ToString();
            }
            connection.Close();


        }
        catch (Exception)
        {


        }
        return minWeight;
    }

    private String MaxWeight()
    {

        String maxWeight = "";
        String type = cmbType.Text;

        try
        {
            String sqlStatement = $@"SELECT MaxWeight 
                                         FROM Templates WHERE Type = '{type}'";

            String connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
            SqlConnection connection = new(connString);
            connection.Open();
            SqlCommand command = new(sqlStatement, connection);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                maxWeight += dataReader[0].ToString();
            }
            connection.Close();
        }
        catch (Exception)
        {
        }
        return maxWeight;
    }

    private static ArrayList GetTypes()
    {
        ArrayList valuesList = new();

        try
        {
            String query = "SELECT DISTINCT Type FROM Templates";

            String connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
            SqlConnection connection = new(connString);
            connection.Open();
            SqlCommand command = new(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                valuesList.Add(dataReader[0].ToString());
            }
            connection.Close();


        }
        catch (Exception)
        {


        }
        return valuesList;
    }

    private void SpecimensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
        BtnSave_Click(sender, e);
    }


    private void BtnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            captureWeight.Visible = true;
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
            String Message = "Are you sure you want to delete ID: " + specimensIDTextBox.Text + "?";
            String Title = "Delete?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(Message, Title
                , buttons, MessageBoxIcon.Question,
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
            if (specimensIDTextBox.Text.Equals("") || cmbType.Text.Equals("") ||
                weightTextBox.Text.Equals("") || createdDateDateTimePicker.Text.Equals("") ||
                lastUpdatedDateTimePicker.Text.Equals("")
                )
            {
                MessageBox.Show("All fields but Notes are required. Please try again.");
                weightTextBox.Focus();
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
            if (cmbType.Text.Length > 64)
            {
                MessageBox.Show("Type max length of 64 characters. Please try again.");
                cmbType.Focus();
                return;
            }

            // check that type length is vaild per template
            ArrayList typesList = GetTypes();
            if (!typesList.Contains(cmbType.Text))
            {
                MessageBox.Show("Type not found in Templates. Please try again.");
                cmbType.Focus();
                return;
            }

            // Sanatize
            specimensIDTextBox.Text = SanatizeSQLString(specimensIDTextBox.Text);
            cmbType.Text = SanatizeSQLString(cmbType.Text);
            typeTextBox.Text = cmbType.Text;
            weightTextBox.Text = SanatizeSQLString(weightTextBox.Text);
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

            // Check weight is valid double
            if (!Double.TryParse(weightTextBox.Text, out double weight))
            {
                MessageBox.Show("Weight given not a valid number. Please try again.");
                weightTextBox.Focus();
                return;
            }

            // Compare weight to template range
            if (Convert.ToDouble(weightTextBox.Text) < Convert.ToDouble(MinWeight()) || Convert.ToDouble(weightTextBox.Text) > Convert.ToDouble(MaxWeight()))
            {
                MessageBox.Show("Weight given not in template range for " + cmbType.Text + ". Min weight of: " + MinWeight() + ", Max weight of: " + MaxWeight() + ". Please try again.");
                weightTextBox.Focus();
                return;
            }

            // Force lastUpdatedDate to now
            lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

            this.Validate();
            this.specimensBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSCDTeam6DataSet);
            captureWeight.Visible = false;
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

            for (int i = 0; i < this.specimensDataGridView.Rows.Count - 1; i++)
            {
                int id = int.Parse(this.specimensDataGridView.Rows[i].Cells[0].Value.ToString());
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
            this.templatesTableAdapter.FillBy(this.cSCDTeam6DataSet.Templates);
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

    private void CmbType_KeyPress(object sender, KeyPressEventArgs e)
    {
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -
        if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
        {
            e.Handled = true;
        }
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

    private void ToolStripButtonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            String combo = SanatizeSQLString(cmbDropDownList.Text);
            String search = SanatizeSQLString(toolStripTextSearchBox.Text);

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

    private static void ExportTOCSV(string data)
    {
        SaveFileDialog save = new()
        {
            Filter = "CSV Files | *.csv",
            Title = "Save your table to a csv file"
        };
        save.ShowDialog();
        if (save.FileName != null)
        {
            try
            {
                StreamWriter sw = new(save.FileName);
                sw.Write(data);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while trying to save your file.  Please try again");
                Console.WriteLine(ex.Message);
            }
        }
    }

    private void OpenToolStripExport_Click(object sender, EventArgs e)
    {
        try
        {
            string res = string.Join(",", Enumerable.Range(0, specimensDataGridView.Columns.Count).Select(i => this.specimensDataGridView.Columns[i].HeaderText).ToArray()) + "\n";
            foreach (DataGridViewRow row in specimensDataGridView.Rows)
            {
                res += string.Join(",", Enumerable.Range(0, row.Cells.Count).Select(i => row.Cells[i].Value).ToArray()) + "\n";
            }
            ExportTOCSV(res);
        }
        catch (Exception)
        {
        }
    }

    private void HomeButton_Click(object sender, EventArgs e)
    {
        Program.CurrentForm = new MainMenu();
        this.Close();
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
        if (Program.CurrentForm.Name == this.Name) //if the current Form has been changed, you can close out of the program
            Program.CurrentForm = null;  //This is done by having the program be called null.

    }

    private void ToolStripButtonClear_Click(object sender, EventArgs e)
    {
        specimensBindingSource.RemoveFilter();
        toolStripTextSearchBox.Clear();
    }

    private Boolean IsUpdated()
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
            String Message = "Are you sure you want to delete ID: " + specimensIDTextBox.Text + "?";
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

    private void ToolStripTextSearchBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -
        if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
        {
            e.Handled = true;
        }
    }

    private void WeightTextBox_TextChanged(object sender, EventArgs e)
    {
        if (weightTextBox.Text == "")
        {
            return;
        }
        else if (!Double.TryParse(weightTextBox.Text, out double weight))
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
        Program.CurrentForm = new TemplatesForm();
        this.Close();
    }

    private void SummaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Program.CurrentForm = new SpecimensSummaryForm();
        this.Close();
    }

    private void GoToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Program.CurrentForm = new MainMenu();
        this.Close();
    }

    private void captureWeight_Click(object sender, EventArgs e)
    {
        Double minWeight = Convert.ToDouble(MinWeight());
        Double maxWeight = Convert.ToDouble(MaxWeight());
        Double capturedWeight = -1;
        Random random = new Random();

        //TO DO: Check if a type is selected and show message if not; round to 4 decimals
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
