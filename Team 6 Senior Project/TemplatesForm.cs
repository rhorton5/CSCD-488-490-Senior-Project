using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_6_Senior_Project
{
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

        private void templatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);

        }

        private void TemplatesForm_Load(object sender, EventArgs e)
        {
            this.templatesTableAdapter.Fill(this.cSCDTeam6DataSet.Templates);

            this.createdDateDateTimePicker.Enabled = false;
            this.lastUpdatedDateTimePicker.Enabled = false;
        }

        private void templatesDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            OriginalType = typeTextBox.Text;
            OriginalMinWeight = minWeightTextBox.Text;
            OriginalMaxWeight = maxWeightTextBox.Text;
            OriginalNotes = notesTextBox.Text;
            OriginalCreatedDate = createdDateDateTimePicker.Text;
            OriginalUpdatedDate = lastUpdatedDateTimePicker.Text;
        }

        private void templatesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click( sender,  e);
        }

        private Boolean isUpdated()
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

        private String sanatizeSQLString(String input)
        {
            // TODO: enhance security by also using SQL parmeters
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?view=dotnet-plat-ext-6.0
            // XSS and SQL-I protection
            // Disallows >, <, ', ", ;, -

            while (input.Contains(">"))
            {
                input = input.Replace(">", "");
            }
            while (input.Contains("<"))
            {
                input = input.Replace("<", "");
            }
            while (input.Contains("'"))
            {
                input = input.Replace("'", "");
            }
            while (input.Contains("\""))
            {
                input = input.Replace("\"", "");
            }
            while (input.Contains(";"))
            {
                input = input.Replace(";", "");
            }
            while (input.Contains("-"))
            {
                input = input.Replace("-", "");
            }
            while (input.Contains("/"))
            {
                input = input.Replace("/", "");
            }
            while (input.Contains("*"))
            {
                input = input.Replace("*", "");
            }

            input = input.Trim();

            return input;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isUpdated())
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
                typeTextBox.Text = sanatizeSQLString(typeTextBox.Text);
                minWeightTextBox.Text = sanatizeSQLString(minWeightTextBox.Text);
                maxWeightTextBox.Text = sanatizeSQLString(maxWeightTextBox.Text);
                notesTextBox.Text = sanatizeSQLString(notesTextBox.Text);

                // Check for valid dates
                DateTime createdDate;
                if (!DateTime.TryParse(createdDateDateTimePicker.Text, out createdDate))
                {
                    MessageBox.Show("Invalid date given for Created Date. Please try again.");
                    createdDateDateTimePicker.Focus();
                    return;
                }
                DateTime lastUpdatedDate;
                if (!DateTime.TryParse(lastUpdatedDateTimePicker.Text, out lastUpdatedDate))
                {
                    MessageBox.Show("Invalid date given for Created Date. Please try again.");
                    lastUpdatedDateTimePicker.Focus();
                    return;
                }

                // Check for valid date range. After 11/1/2021, less than or equal to now
                DateTime startDate = new DateTime(2021, 11, 1, 0, 0, 0);
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
                Double minWeight;
                if (!Double.TryParse(minWeightTextBox.Text, out minWeight))
                {
                    MessageBox.Show("Min Weight given outnot a valid number. Please try again.");
                    minWeightTextBox.Focus();
                    return;
                }
                // Check maxweight is valid double
                Double maxWeight;
                if (!Double.TryParse(maxWeightTextBox.Text, out maxWeight))
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

        private void minWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void maxWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void notesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // XSS and SQL-I protection
            // Disallows >, <, ', ", ;, -

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void typeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // XSS and SQL-I protection
            // Disallows >, <, ', ", ;, -

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void toolStripTextSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // XSS and SQL-I protection
            // Disallows >, <, ', ", ;, -

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String combo = sanatizeSQLString(cmbDropDownList.Text);
                String search = sanatizeSQLString(toolStripTextSearchBox.Text);


                // TODO: Doesn't work for non-string fields? Check is sql doesn't use quotes for numbers
                string searchIndvidual = combo + " like '%" + search + "%'";
                templatesBindingSource.Filter = searchIndvidual;
            }
            catch (Exception)
            {
            }
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            templatesBindingSource.RemoveFilter();
            toolStripTextSearchBox.Clear();
        }

        private void minWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check weight is valid double
            Double weight;
            if (minWeightTextBox.Text == "")
            {
                return;
            }
            else if(!Double.TryParse(minWeightTextBox.Text, out weight))
            {
                MessageBox.Show("Min Weight given not a valid number. Please try again.");
                minWeightTextBox.Focus();
                return;
            }
        }

        private void maxWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check weight is valid double
            Double weight;
            if (maxWeightTextBox.Text == "")
            {
                return;
            }
            else if(!Double.TryParse(maxWeightTextBox.Text, out weight))
            {
                MessageBox.Show("Max Weight given not a valid number. Please try again.");
                minWeightTextBox.Focus();
                return;
            }
        }

        private void ExportTOCSV(string data)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "CSV Files | *.csv",
                Title = "Save your table to a csv file"
            };
            save.ShowDialog();
            if (save.FileName != null)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(save.FileName);
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

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string res = string.Join(",", Enumerable.Range(0, templatesDataGridView.Columns.Count).Select(i => this.templatesDataGridView.Columns[i].HeaderText).ToArray()) + "\n";
                foreach (DataGridViewRow row in templatesDataGridView.Rows)
                {
                    res += string.Join(",", Enumerable.Range(0, row.Cells.Count).Select(i => row.Cells[i].Value).ToArray()) + "\n";
                }
                ExportTOCSV(res);
            }
            catch (Exception)
            {
            }
        }

        private void templatesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void TemplatesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Figure out how to bring back MainMenu, Ryley!
            Application.Exit();
        }
    }       
}
    

