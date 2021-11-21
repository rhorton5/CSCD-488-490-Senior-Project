﻿using System;
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
            this.lastUpdatedIndex = this.lastUpdatedDataGridViewTextBoxColumn.Index;
            this.createdAtIndex = this.createdDateDataGridViewTextBoxColumn.Index;
            for (int i = 0; i < this.SpecimensDataGridView.Columns.Count; i++)
            {
                this.searchComboBox.Items.Add(this.SpecimensDataGridView.Columns[i].HeaderText);
            }
            foreach(DataGridViewRow row in this.SpecimensDataGridView.Rows)
            {
                if(row.Cells[0].Value != null)//Not good implementation
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
            DataTable dataTable = new DataTable();
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                if(dataTable.Columns.Count > 0)
                {
                    dataTable.Rows.Add(sr.ReadLine().Split(','));

                }
                else
                {
                    foreach(string columns in sr.ReadLine().Split(','))
                    {
                        dataTable.Columns.Add(columns);
                    }
                }
            }
            sr.Close();
            return dataTable;
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Specimens WHERE Type LIKE '%" + searchTextBox.Text + 
                    "%' OR WEIGHT LIKE '%" + searchTextBox.Text +
                    "%' OR Notes LIKE '%" + searchTextBox.Text +
                    "%' OR CreatedDate LIKE '%" + searchTextBox.Text +
                    "%' OR LastUpdated LIKE '%" + searchTextBox.Text +
                    "%'", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtSpecimens.Load(reader);
                }
            }
            return dtSpecimens;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SpecimensDataGridView.DataSource = SearchSpecimens();
        }

        private void SpecimensDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.SpecimensDataGridView.Rows[e.RowIndex];
            row.Cells[this.lastUpdatedIndex].Value = DateTime.Now;
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
            WindowChanger wc = new WindowChanger();
            wc.changeWindows(this, new MainMenu());
        }
    }    
}
