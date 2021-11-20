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
        public TableMenu(string fileName)
        {
            this.fileName = fileName;
            InitializeComponent();

        }

        private void TableMenu_Load(object sender, EventArgs e)
        {
            SpecimensDataGridView.DataSource = GetSpecimens();
        }

        private DataTable GetSpecimens()
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
    }    
}
