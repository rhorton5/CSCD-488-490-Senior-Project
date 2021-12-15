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
    public partial class TemplatesForm : Form
    {
        public TemplatesForm()
        {
            InitializeComponent();
        }

        private void templatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.templatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSCDTeam6DataSet);

        }

        private void TemplatesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSCDTeam6DataSet.Templates' table. You can move, or remove it, as needed.
            this.templatesTableAdapter.Fill(this.cSCDTeam6DataSet.Templates);

        }
    }
}
