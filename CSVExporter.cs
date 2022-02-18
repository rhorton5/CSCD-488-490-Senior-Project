namespace Team_6_Senior_Project;

internal class CSVExporter
{
    private static void ExportTOCSV(string data)
    {
        SaveFileDialog save = new()
        {
            Filter = "CSV Files | *.csv",
            Title = "Save your table to a csv file"
        };
        if (save.ShowDialog() == DialogResult.OK && save.FileName != null)
        {
            try
            {
                StreamWriter sw = new(save.FileName);
                sw.Write(data);
                sw.Close();
                MessageBox.Show("Your file has been exported to " + save.FileName + "!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while trying to save your file.  Please try again");
                Console.WriteLine(ex.Message);
            }
        }
        save.Dispose();
    }

    public static void Export(DataGridView dataGridView)
    {
        try
        {
            string res = "";
            //Get Columns to one row.
            for(int i = 0; i < dataGridView.Columns.Count - 1; i++) //Run until it raeches the last item.
            {
                res += dataGridView.Columns[i].HeaderText + ",";
            }
            res = dataGridView.Columns[dataGridView.Columns.Count - 1].HeaderText + "\n";//Last item does not need a comma.

            //Get the remaining rows
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                for(int i = 0; i < row.Cells.Count - 1; i++)
                {
                    res += row.Cells[i].Value + ",";
                }
                res += row.Cells[row.Cells.Count-1].Value + "\n";
            }
            ExportTOCSV(res);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An Error has occurred when exporting to csv..." + ex.Message);
        }
    }
}
