using System;
/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
using System.Windows.Forms;

namespace Team_6_Senior_Project
{
    public partial class MainMenu : Form
    {
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
         * openExistingButton_Click is used to return a filePath that the user specifies that can be used 
         * 
         */

        private void changeWindows(Form orig, Form dest)
        {
            orig.Visible = false;
            dest.FormClosed += (s, args) => orig.Close();
            dest.Show();
        }
        
        private void openExistingButton_Click(object sender, EventArgs e) {
            String filePath = getFileString();
            if (filePath != null)
            {
                MessageBox.Show(String.Format("{0} was found!", filePath));
                changeWindows(this, new TableMenu(filePath));

            }
                
        }

        private void createNewTableButton_Click(object sender, EventArgs e)
        {
            TableMenu tableMenu = new TableMenu(null);
            changeWindows(this, tableMenu);
        }

        private void setDefaultTableButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("setDefautTableButton has been pressed!");
        }

    }
}
