using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_6_Senior_Project
{
    public partial class MainMenu : Form
    {
        private WindowChanger changer = new WindowChanger();
        private Boolean closeByNewForm = false;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
         * getFileString opens up File Explorer and has the user look for a file they want to 
         * use as a file.  If a file was found the DialogResult object and it is not null or Empty
         * it will return the filename for the program to use.
         * 
         */

        private String getFileString()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(openFileDialog.FileName)) {
                    return openFileDialog.FileName;
            }
            return null;
        }

        /*
         * openExistingButton_Click is used to return a filePath that the user specifies that can be used for the program.
         * It will create TableMenu but load new data in first.
         * 
         */
        private void openExistingButton_Click(object sender, EventArgs e) {
            String filePath = getFileString();
            //if (filePath != null)
                //this.changer.changeWindows(this, new TableMenu(filePath));
            if(filePath != null)
            {
                Program.runViewAll = true;
                Program.filenameViewAll = filePath;
                this.closeByNewForm = true;
                this.Close();
            }
        }

        /*
         * createNewTableButton_Click will open a new window but will no new information for the user to use.
         */
        private void createNewTableButton_Click(object sender, EventArgs e)
        {
            //TableMenu tableMenu = new TableMenu(null);
            //this.changer.changeWindows(this, tableMenu);
            Program.runViewAll = true;
            Program.filenameViewAll = null;
            this.closeByNewForm = true;
            this.Close();

        }


        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.closeByNewForm)
            {
                Program.closeProgram = true;
            }
        }

        private void btnSpecimens_Click(object sender, EventArgs e)
        {
            //TODO: have Ryley do this his way, it's better
            MainMenu.ActiveForm.Hide();

            SpecimensForm fm = new SpecimensForm();
            fm.Show();
        }

        private void btnTemplates_Click(object sender, EventArgs e)
        {
            //TODO: have Ryley do this his way, it's better
            MainMenu.ActiveForm.Hide();

            TemplatesForm fm = new TemplatesForm();
            fm.Show();
        }

        private void btnSpecimensSummary_Click(object sender, EventArgs e)
        {
            //TODO: have Ryley do this his way, it's better
            MainMenu.ActiveForm.Hide();

            SpecimensSummaryForm fm = new SpecimensSummaryForm();
            fm.Show();
        }
    }
}
