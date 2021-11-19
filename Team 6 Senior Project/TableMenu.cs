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
    public partial class TableMenu : Form
    {
        private string fileName;
        public TableMenu(string fileName)
        {
            this.fileName = fileName;
            InitializeComponent();
        }

        protected string[] SetDefaultColumns() => new string[] { "Name", "Entry Date", "ID#", "Weight", "Notes" };
        protected DataTable GetDataTable(string fileName)
        {
            DataTable dt = new DataTable();
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                if(dt.Columns.Count == 0)
                {
                    foreach(string colName in SetDefaultColumns())
                    {
                        dt.Columns.Add(colName);
                        
                    }
                    sr.ReadLine(); //Skip one line after Column
                }
                else
                {
                    dt.Rows.Add(sr.ReadLine().Split(','));
                }
            }
            return dt;
        }

        protected DataTable SetBlankDataTable()
        {
            DataTable dt = new DataTable();
            foreach (string colName in SetDefaultColumns())
            {
                dt.Columns.Add(colName);

            }
            return dt;
        }

        private void TableMenu_Load(object sender, EventArgs e)
        {
            this.specimenDataGrid.DataSource = (this.fileName != null) ?  GetDataTable(this.fileName) : SetBlankDataTable();
        }

        private void searchByLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
}
