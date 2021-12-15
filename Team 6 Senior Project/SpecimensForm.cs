﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace Team_6_Senior_Project
{
    public partial class SpecimensForm : Form
    {
        String OriginalSpecimenID;
        String OriginalType;
        String OriginalWeight;
        String OriginalNotes;
        String OriginalCreatedDate;
        String OriginalUpdatedDate;

        public SpecimensForm()
        {
            InitializeComponent();
        }
        private void SpecimensForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.specimensTableAdapter.Fill(this.cSCDTeam6DataSet.Specimens);

                ArrayList typesList = getTypes();
                this.cmbType.Items.AddRange(typesList.ToArray());
            }
            catch (Exception)
            {
            }
        }


        private String minWeight()
        {

            String minWeight = "";

            try
            {
                String query = "SELECT MinWeight FROM Templates WHERE Type = '" + cmbType.Text + "'";

                String connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

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

        private String maxWeight()
        {

            String minWeight = "";

            try
            {
                String query = "SELECT MaxWeight FROM Templates WHERE Type = '" + cmbType.Text + "'";

                String connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

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

        private ArrayList getTypes()
        {
            
            ArrayList valuesList = new ArrayList();
            
            try
            {
                String query = "SELECT DISTINCT Type FROM Templates";

                String connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

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

        private void specimensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                specimensBindingSource.AddNew();
                specimensIDTextBox.Text = setSpecimenID().ToString();
                createdDateDateTimePicker.Text = DateTime.Now.ToString();
                lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

                typeTextBox.Focus();
            }
            catch (Exception)
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                specimensBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: set created date to read only
            try
            {
                //check if anything changed
                if (!isUpdated())
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
                    MessageBox.Show("All feilds but Notes are required. Please try again.");
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
                ArrayList typesList = getTypes();
                if (!typesList.Contains(cmbType.Text))
                {
                    MessageBox.Show("Type not found in Templates. Please try again.");
                    cmbType.Focus();
                    return;
                }

                // Sanatize
                specimensIDTextBox.Text = sanatizeSQLString(specimensIDTextBox.Text);
                cmbType.Text = sanatizeSQLString(cmbType.Text);
                typeTextBox.Text = cmbType.Text;
                weightTextBox.Text = sanatizeSQLString(weightTextBox.Text);
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

                // Check weight is valid double
                Double weight;
                if (!Double.TryParse(weightTextBox.Text, out weight))
                {
                    MessageBox.Show("Weight given outnot a valid number. Please try again.");
                    weightTextBox.Focus();
                    return;
                }

                // Compare weight to template range
                if (Convert.ToDouble(weightTextBox.Text) < Convert.ToDouble(minWeight()) || Convert.ToDouble(weightTextBox.Text) > Convert.ToDouble(maxWeight()))
                {
                    MessageBox.Show("Weight given out of template range for " + cmbType.Text +  ". Min weight of: " + minWeight() + ", Max weight of: " + maxWeight() + ". Please try again.");
                    weightTextBox.Focus();
                    return;
                }

                // Force lastUpdatedDate to now
                lastUpdatedDateTimePicker.Text = DateTime.Now.ToString();

                this.Validate();
                this.specimensBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cSCDTeam6DataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Save failed, try again. Were all your entries valid?");
            }
        }

        private int setSpecimenID()
        {
            int maxValue = -1;
            try
            {
                specimensBindingSource.RemoveFilter();
                toolStripTextSearchBox.Clear();

                for (int i = 0; i < this.specimensDataGridView.Rows.Count - 2; i++)//Exclude new row and empty row by subtracting by two.
                {
                    int id = int.Parse(this.specimensDataGridView.Rows[i].Cells[0].Value.ToString());
                    if (id > maxValue) { 
                        maxValue = id; 
                    }
                }
            }
            catch (Exception)
            {
            }
            return maxValue + 1;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
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

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {
            // TODO: Update combobox cmbType to by dynamic and pull from templates
            typeTextBox.Text = cmbType.Text;
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            // XSS and SQL-I protection
            // Disallows >, <, ', ", ;, -

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Doesn't work for non-string feilds?
                string searchIndvidual = cmbDropDownList.Text + " like '%" + toolStripTextSearchBox.Text + "%'";
                specimensBindingSource.Filter = searchIndvidual;
            }
            catch (Exception)
            {

            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender,  e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
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

        private void openToolStripExport_Click(object sender, EventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //TODO: Figure out how to bring back MainMenu

        }

        private void SpecimensForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Figure out how to bring back MainMenu

        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            specimensBindingSource.RemoveFilter();
            toolStripTextSearchBox.Clear();
        }

        private Boolean isUpdated()
        {
            // check if anything changed
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

        private void specimensDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            OriginalSpecimenID = specimensIDTextBox.Text;
            OriginalType = typeTextBox.Text;
            OriginalWeight = weightTextBox.Text;
            OriginalNotes = notesTextBox.Text;
            OriginalCreatedDate = createdDateDateTimePicker.Text;
            OriginalUpdatedDate = lastUpdatedDateTimePicker.Text;
        }
    }
}
