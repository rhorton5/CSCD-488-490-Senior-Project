using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_6_Senior_Project
{
    internal class CSVExporter
    {
        private static void ExportTOCSV(string data)
        {
            SaveFileDialog save = new()
            {
                Filter = "CSV Files | *.csv",
                Title = "Save your table to a csv file"
            };
            save.ShowDialog();
            if (save.FileName != null)
            {
                try
                {
                    StreamWriter sw = new(save.FileName);
                    sw.Write(data);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured while trying to save your file.  Please try again");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void Export(DataGridView dataGridView)
        {
            try
            {
                string res = string.Join(",", Enumerable.Range(0, dataGridView.Columns.Count).Select(i => dataGridView.Columns[i].HeaderText).ToArray()) + "\n";
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    res += string.Join(",", Enumerable.Range(0, row.Cells.Count).Select(i => row.Cells[i].Value).ToArray()) + "\n";
                }
                ExportTOCSV(res);
            }
            catch (Exception)
            {
            }
        }
    }
}
