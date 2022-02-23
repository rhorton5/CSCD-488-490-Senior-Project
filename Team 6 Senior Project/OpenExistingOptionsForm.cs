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
    public partial class OpenExistingOptionsForm : Form
    {
        public OpenExistingOptionsForm()
        {
            InitializeComponent();
        }

        private void backupDatabaseButton_CheckedChanged(object sender, EventArgs e)
        {
            saveFolderTextBox.Enabled = !saveFolderTextBox.Enabled;
            openSaveLocationButton.Enabled = !openSaveLocationButton.Enabled;
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(dialog.FileName))
                {
                    folderNameTextBox.Text = dialog.FileName;
                    confirmButton.Enabled = true;
                }
            }
        }

        private void openSaveLocationButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(dialog.FileName))
                {
                    saveFolderTextBox.Text = dialog.FileName;
                }
            }
        }

        private void mergeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!saveFolderTextBox.Enabled)
                saveFolderTextBox.Enabled = true;
            if(!openSaveLocationButton.Enabled)
                openSaveLocationButton.Enabled = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Warning: You are about to rewrite the entire database to your imported file.  Please make sure the options you have selected are what you want.  You cannot recover data erased after the files are imported. Do you wish to confirm?", 
                "Warning!",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Work in Progress...");
                this.DialogResult = DialogResult.OK; //Needed for Exiting Main Menu.
                this.Close();
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
