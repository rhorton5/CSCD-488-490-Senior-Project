using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace Team_6_Senior_Project;

internal class SQLStatements
{
    public static string GetOneValueFromSelectStatement(string query)
    {
        string returnValue = "";

        try
        {
            string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
            SqlConnection connection = new(connString);
            connection.Open();
            SqlCommand command = new(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                returnValue += dataReader[0].ToString();
            }

            command.Dispose();
            connection.Close();
            connection.Dispose();

        }
        catch (Exception)
        {
            //TODO: handle exceptions better
            return "";
        }

        return returnValue;
    }

    public static ArrayList GetArrayListOfValuesFromSelectStatement(string query)
    {
        ArrayList valuesList = new();

        try
        {
            string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
            SqlConnection connection = new(connString);
            connection.Open();
            SqlCommand command = new(query, connection);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                valuesList.Add(dataReader[0].ToString());
            }
            command.Dispose();
            connection.Close();
            connection.Dispose();

        }
        catch (Exception)
        {
            //TODO: handle exceptions better
            return valuesList;
        }

        return valuesList;
    }

    public static DataTable GetDataTableFromSelectStatement(string query)
    {
        DataTable dataTable = new();

        try
        {
            string connString = ConfigurationManager.ConnectionStrings["Team_6_Senior_Project.Properties.Settings.CSCDTeam6ConnectionString"].ConnectionString;
            using SqlConnection con = new(connString);
            using SqlCommand cmd = new(query, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            dataTable.Load(reader);
        }
        catch (Exception)
        {
            //TODO: handle exceptions better
            return dataTable;
        }

        return dataTable;
    }

    public static ArrayList GetTemplatesTypes()
    {
        string query = $@"SELECT DISTINCT Type 
                          FROM Templates";

        return GetArrayListOfValuesFromSelectStatement(query);
    }
    public static string MinWeight(string type)
    {
        string query = $@"SELECT MinWeight 
                          FROM Templates WHERE Type = '{type}'";

        return GetOneValueFromSelectStatement(query); ;
    }
    public static string MaxWeight(string type)
    {
        string query = $@"SELECT MaxWeight 
                          FROM Templates WHERE Type = '{type}'";

        return GetOneValueFromSelectStatement(query);
    }

    public static DataTable GetSpecimenData()
    {
        string query = $@"SELECT * From Specimens";
        return GetDataTableFromSelectStatement(query);
    }
}
