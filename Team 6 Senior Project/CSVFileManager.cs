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
                CSCDTeam6DataSet.SpecimensDataTable sdt = new();
                string str = "";
                foreach (DataColumn column in sdt.Columns)
                {
                    str += column.ColumnName + ",";
                }
                data = str + data;
                sdt.Dispose();
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

    public static void BackupToCSV(string saveLocation)
    {
        CSCDTeam6DataSet.SpecimensDataTable sdt = new();
        string str = "";
        foreach(DataColumn column in sdt.Columns)
        {
            str += column.ColumnName + ",";
        }
        sdt.Dispose();
        str = string.Concat(str.AsSpan(0, str.Length - 1), "\n");
        DataTable dt = SQLStatements.GetSpecimenData();
        if (!String.IsNullOrEmpty(saveLocation)){
            foreach(DataRow row in dt.Rows)
            {
                str += String.Join(",",row.ItemArray) + "\n";
            }
        }
        try
        {
            StreamWriter sw = new StreamWriter(saveLocation);
            sw.Write(str);
            sw.Close();

        }catch (Exception ex)
        {
            MessageBox.Show("Failed to Save.");
        }
        dt.Dispose();
    }

    public static void Export(DataGridView dataGridView)
    {
        try
        {
            string res = "";
            for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                res += dataGridView.Columns[i].HeaderText + ",";
            }
            res = String.Concat(res.AsSpan(0, res.Length - 2), "\n");
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                foreach (DataGridViewCell cell in dataGridView.Rows[i].Cells)
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

    public static void Import(string FileName)
    {
        string csvStr = "";
        try
        {
            using (StreamReader sr = new StreamReader(FileName)) //Throw MessageBox about processing being used.
            {
                while (!sr.EndOfStream)
                {
                    csvStr += sr.ReadLine() + "\n";
                }
            }
            string[] rows = csvStr.Split("\n");
            DataTable dt = new("Importing Item");
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
            specimenTable = RemoveInvalidRows(dt, specimenTable);
            specimenTable.Update(source);
            source.AcceptChanges();

            dt.Dispose();
            source.Dispose();
            specimenTable.Dispose();
        }catch(IOException ex)
        {
            MessageBox.Show("Please close out of the program running your csv files and try again","Unable to Run CSV File",MessageBoxButtons.OK,MessageBoxIcon.Error);
            Console.WriteLine(ex.ToString());
        }
        
    }

    private static CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter RemoveInvalidRows(DataTable dt, CSCDTeam6DataSetTableAdapters.SpecimensTableAdapter adapter)
    {
        ArrayList typesList = SQLStatements.GetTemplatesTypes();  //Called here to avoid multiple calls.
        String removedDataMSG = "";
        foreach (DataRow dr in dt.Rows)
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
                break;
            }

            string notes = DataValidation.SanatizeSQLString(dr.ItemArray[3].ToString());

            if (!typesList.Contains(type) || !DataValidation.WeightIsInTemplateMinMax(type, weight) || !DataValidation.ValidNotesRange(notes)
                || !DataValidation.ValidDateRange(lastCreatedDate) || !DataValidation.ValidDateRange(createdDate))
            {
                removedDataMSG += String.Join(",",dr.ItemArray.ToArray()) + Environment.NewLine;
            }
            else
            {
                adapter.Insert(type, Decimal.Parse(weight), notes, createdDate, lastCreatedDate);
            }
        }
        if (String.IsNullOrEmpty(removedDataMSG))
            MessageBox.Show("All of your rows have been imported!!", "Successful Import");
        else
            MessageBox.Show("The following rows have not been added: " + Environment.NewLine + removedDataMSG, "Some Rows Did Not Get Imported", MessageBoxButtons.OK, MessageBoxIcon.Error);

        return adapter;
    }
}