using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_6_Senior_Project
{
    
    public partial class TableMenu : Form
    {
        private WindowChanger wc = new WindowChanger();
        public TableMenu(String fileName)
        {
            InitializeComponent(fileName);
        }

        private void AddMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}", "Add"));
        }

        private void RemoveMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}", "Remove"));
        }

        private void ExportMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}", "Export"));
        }

        private void TemplatesMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}", "Template"));
        }

        private void DataSummaryMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}", "Data"));
        }
        
        private void StartMenu_Click(object sender, EventArgs e)
        {
            this.wc.changeWindows(this, new MainMenu());
        }

        private void TableMenu_Load(object sender, EventArgs e)
        {

        }

        private void templateName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
