using System;
using System.Collections;
using System.Data;

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

    public static DataTable Import(string FileName)
    {
        string csvStr = "";
        using(StreamReader sr = new StreamReader(FileName)) //Throw MessageBox about processing being used.
        {
            while (!sr.EndOfStream)
            {
                csvStr += sr.ReadLine() + "\n";
            }
        }
        string[] rows = csvStr.Split("\n");
        System.Data.DataTable dt = new DataTable("Importing Item");
        foreach (string str in rows[0].Split(","))
        {
            dt.Columns.Add(str);
        }
        for (int i = 1; i < rows.Length; i++)
        {
            System.Data.DataRow dataRow = dt.NewRow();
            dataRow.ItemArray = rows[i].Split(",");
            dt.Rows.Add(dataRow);
        }

        CSCDTeam6DataSet.SpecimensDataTable source = new();
        source.GetChanges(DataRowState.Added);

        CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter specimenTable = new();
        specimenTable = RemoveInvalidRows(dt,specimenTable);
        specimenTable.Update(source);
        source.AcceptChanges();

        source.Dispose();
        specimenTable.Dispose();


        return null;
    }

    private static CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter RemoveInvalidRows(DataTable dt, CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter adapter)
    {
        System.Data.DataTable res = dt;
        ArrayList typesList = SQLStatements.GetTemplatesTypes();  //Called here to avoid multiple calls.
        ArrayList RowsToRemove = new ArrayList();
        foreach (DataRow dr in dt.Rows)
        {
            string specimenID = dr.ItemArray[0].ToString();
            if (!int.TryParse(specimenID, out int id))
            {
                RowsToRemove.Add(dr);
                System.Diagnostics.Debug.WriteLine("Invalid Specimen ID " + specimenID + "!");
            }
            else
            {
                string type = dr.ItemArray[1].ToString();
                string weight = dr.ItemArray[2].ToString();
                DateTime createdDate, lastCreatedDate;
                try
                {
                    createdDate = DateTime.Parse(dr.ItemArray[4].ToString());
                    lastCreatedDate = DateTime.Parse(dr.ItemArray[5].ToString());
                }
                catch (Exception)
                {
                    System.Diagnostics.Debug.WriteLine("DateTime(s) Created An Error -> Row Deleted!");
                    RowsToRemove.Add(dr);
                    break;
                }

                string notes = DataValidation.SanatizeSQLString(dr.ItemArray[3].ToString());

                if (!typesList.Contains(type) || !DataValidation.WeightIsInTemplateMinMax(type, weight) || !DataValidation.ValidNotesRange(notes)
                    || !DataValidation.ValidDateRange(lastCreatedDate) || !DataValidation.ValidDateRange(createdDate))
                {
                    RowsToRemove.Add(dr);
                    System.Diagnostics.Debug.WriteLine("Row Deleted!"); //Kept for debugging purposes, you may delete at any time.

                }
                else
                {
                    adapter.Insert(type, Decimal.Parse(weight), notes, createdDate, lastCreatedDate);
                    System.Diagnostics.Debug.WriteLine("Row Saved!"); //Kept for debugging purposes, you may delete at any time.
                }
            }
        }
        foreach (DataRow dr in RowsToRemove)
        {
            res.Rows.Remove(dr);
        }
        return adapter;
    }
}
