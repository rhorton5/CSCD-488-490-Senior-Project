﻿using System;
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
    public partial class OpenExistingOptionsMenu : Form
    {
        public OpenExistingOptionsMenu(string FileName)
        {
            InitializeComponent();
            existingFileTextBox.Text = FileName;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void browseExistingButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(dialog.FileName))
                {
                    existingFileTextBox.Text = dialog.FileName;
                    confirmButton.Enabled = true;
                }
            }
        }

        private void backupFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(dialog.FileName))
                {
                    backupFileTextBox.Text = dialog.FileName;
                }
            }
        }

        private void existingFileTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmButton.Enabled = File.Exists(existingFileTextBox.Text);
        }
    }
}
