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
using System.Configuration;
using System.Data.SqlClient;


namespace Team_6_Senior_Project
{

    public partial class TableMenu : Form
    {
        private string fileName;
        private bool returnToMainMenu = false;

        private int idIndex;
        private int typeIndex;
        private int weightindex;
        private int notesIndex;
        private int lastUpdatedIndex;
        private int createdAtIndex;

        
        public TableMenu(string fileName)
        {
            this.fileName = fileName;
            InitializeComponent();

        }

        private void TableMenu_Load(object sender, EventArgs e)
        {


            this.SpecimensDataGridView.DataSource = (this.fileName == null) ? GetSpecimensFromDatabase() : GetSpecimensFromFile(this.fileName);
            
            this.idIndex = this.specimensIDDataGridViewTextBoxColumn.Index;
            this.typeIndex = this.typeDataGridViewTextBoxColumn.Index;
            this.weightindex = this.weightDataGridViewTextBoxColumn.Index;
            this.notesIndex = this.notesDataGridViewTextBoxColumn.Index;
            this.lastUpdatedIndex = this.lastUpdatedDataGridViewTextBoxColumn.Index;
            this.createdAtIndex = this.createdDateDataGridViewTextBoxColumn.Index;




            this.searchComboBox.Items.Add("All Attributes");
            for (int i = 0; i < this.SpecimensDataGridView.Columns.Count; i++)
            {
                this.searchComboBox.Items.Add(this.SpecimensDataGridView.Columns[i].HeaderText);
            }
            foreach(DataGridViewRow row in this.SpecimensDataGridView.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    if (row.Cells[this.createdAtIndex].Value == null)
                        row.Cells[this.createdAtIndex].Value = DateTime.Now;
                    if (row.Cells[this.lastUpdatedIndex].Value == null)
                        row.Cells[this.lastUpdatedIndex].Value = DateTime.Now;
                }
                
            }
        }
        
        private DataTable GetSpecimensFromFile(string fileName)
        {
            try
            {
                DataTable dataTable = new DataTable();
                StreamReader sr = new StreamReader(fileName);
                while (!sr.EndOfStream)
                {
                    if (dataTable.Columns.Count > 0)
                    {
                        dataTable.Rows.Add(sr.ReadLine().Split(','));

                    }
                    else
                    {
                        foreach (string columns in sr.ReadLine().Split(','))
                        {
                            dataTable.Columns.Add(columns);
                        }
                    }
                }
                sr.Close();
                return dataTable;
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error with importing your file.\nYou will start with a blank message.  Press Start Menu to return to the menu.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return null;
           
        }
        
        private DataTable GetSpecimensFromDatabase()
        {
            DataTable dtSpecimens = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Specimens", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtSpecimens.Load(reader);
                }
            }


                return dtSpecimens;
        }

        private DataTable SearchSpecimens()
        {
            DataTable dtSpecimens = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                //TODO: Add ID
                //TODO: consider dropping dates from all search as including many when searching for any number


                using (SqlCommand cmd = new SqlCommand("SELECT * " +
                    "FROM Specimens " +
                    "WHERE Type LIKE '%" + searchTextBox.Text + 
                    "%' OR WEIGHT LIKE '%" + searchTextBox.Text +
                    "%' OR Notes LIKE '%" + searchTextBox.Text +
                    "%' OR CreatedDate LIKE '%" + searchTextBox.Text +
                    "%' OR LastUpdated LIKE '%" + searchTextBox.Text +
                    "%'"
                    , con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtSpecimens.Load(reader);

                    con.Close();
                }
            }
            return dtSpecimens;
        }

        private DataTable SearchSpecimensWithAttributes()
        {
            DataTable dtSpecimens = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;

            using(SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    String.Format(
                        "SELECT * FROM Specimens WHERE {0} LIKE '%{1}%'",
                        this.searchComboBox.Text,
                        this.searchTextBox.Text),con
                    )
                )
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtSpecimens.Load(reader);

                    con.Close();
                }
            }
            return dtSpecimens;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SpecimensDataGridView.DataSource = (String.IsNullOrEmpty(this.searchComboBox.Text) || this.searchComboBox.Text == "All Attributes") ? SearchSpecimens() : SearchSpecimensWithAttributes();
        }

        private int setSpecimenID()
        {
            // TODO: see if count includes all or if affected by filter. Would error if trying to add an existing ID
            int maxValue = -1;
            for(int i = 0; i < this.SpecimensDataGridView.Rows.Count - 2; i++)//Exclude new row and empty row by subtracting by two.
            {
                int id = int.Parse(this.SpecimensDataGridView.Rows[i].Cells[0].Value.ToString());
                if(id > maxValue)
                    maxValue = id;

            }
            return maxValue + 1;
        }

        private void SpecimensDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.SpecimensDataGridView.Rows[e.RowIndex];

                if(row.Cells[this.createdAtIndex].Value.Equals(null))
                {
                    row.Cells[this.createdAtIndex].Value = DateTime.Now;
                }

                if (row.Cells[this.lastUpdatedIndex].Value.Equals(null))
                {
                    row.Cells[this.lastUpdatedIndex].Value = DateTime.Now;
                }

                if (row.Cells[this.idIndex].Value == null ||
                    row.Cells[this.typeIndex].Value == null ||
                    row.Cells[this.weightindex].Value == null ||
                    row.Cells[this.notesIndex].Value == null ||
                    row.Cells[this.createdAtIndex].Value == null ||
                    row.Cells[this.lastUpdatedIndex].Value == null)
                {
                    //TODO: come up with a better fix than forcing them to stay in the row
                    // force out with escape key
                    return;
                }
            }
            catch (Exception)
            {
            }
        }

        private void SpecimensDataGridView_DataSourceChanged(Object sender, EventArgs e)
        {

        }

        private void ExportTOCSV(string data)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "CSV Files | *.csv",
                Title = "Save your table to a csv file"
            };
            save.ShowDialog();
            if(save.FileName != null)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(save.FileName);
                    sw.Write(data);
                    sw.Close();
                }catch (Exception ex)
                {
                    MessageBox.Show("An error has occured while trying to save your file.  Please try again");
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string res = string.Join(",", Enumerable.Range(0, SpecimensDataGridView.Columns.Count).Select(i => this.SpecimensDataGridView.Columns[i].HeaderText).ToArray()) + "\n";
            foreach(DataGridViewRow row in SpecimensDataGridView.Rows)
            {
                res += string.Join(",", Enumerable.Range(0,row.Cells.Count).Select(i => row.Cells[i].Value).ToArray()) + "\n";
            }
            ExportTOCSV(res);
        }

        private void startMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.returnToMainMenu = true;
            this.Close();
        }

        private void SpecimensDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
        }

        private void TableMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && !this.returnToMainMenu)
            {
                Program.closeProgram = true;
            }
            Program.runViewAll=false;
        }

        private void SpecimensDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // TODO: remove this funciton as it is supressing errors from the data grid table
            e.Cancel = true;
        }

        private void SpecimensDataGridView_KeyPress(object sender, KeyPressEventArgs e)
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

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }    
}
