using System;

namespace Team_6_Senior_Project;

internal class CSVFileManager
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
            for(int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                res += dataGridView.Columns[i].HeaderText + ",";
            }
            res = String.Concat(res.AsSpan(0, res.Length - 2), "\n");
            for(int i = 0; i < dataGridView.Rows.Count; i++)
            {
                foreach(DataGridViewCell cell in dataGridView.Rows[i].Cells)
                {
                    res += cell.Value + ",";
                }
                res = string.Concat(res.AsSpan(0, res.Length - 2), "\n");
            }
            ExportTOCSV(res);
        }
        catch (Exception)
        {
        }
    }

    public static string Import(string FileName)
    {
        string str = "";
        using(StreamReader sr = new StreamReader(FileName))
        {
            while (!sr.EndOfStream)
            {
                str += sr.ReadLine() + "\n";
            }
        }
        return str;
    }
}
