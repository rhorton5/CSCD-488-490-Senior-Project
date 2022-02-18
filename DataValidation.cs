using System.Collections;
using static Team_6_Senior_Project.SQLStatements;

namespace Team_6_Senior_Project;

internal class DataValidation
{
    public static void KeyPressNumeric(object sender, KeyPressEventArgs e)
    {
        // Disallows all characters that are not controls digits or period "."
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }
        // Limits to only one period "."
        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }

    public static void KeyPressNotes(object sender, KeyPressEventArgs e)
    {
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -
        if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
        {
            e.Handled = true;
        }
    }

    public static bool ValidNotesRange(string notes)
    {
        if (notes.Length > 255)
        {
            return false;
        }
        return true;
    }

    public static bool ValidDateRange(DateTime date)
    {
        DateTime startDate = new(2021, 11, 1, 0, 0, 0);
        if (date <= startDate || date >= DateTime.Now)
        {
            return false;
        }
        return true;
    }

    public static bool ValidTypeRange(string type)
    {
        if (type.Length > 64)
        {
            return false;
        }
        return true;
    }


    public static bool TypeIsInTemplate(string type)
    {
        ArrayList typesList = GetTemplatesTypes();
        if (!typesList.Contains(type))
        {
            return false;
        }

        return true;
    }

    public static bool WeightIsInTemplateMinMax(string type, string weight)
    {
        if (Convert.ToDouble(weight) < Convert.ToDouble(MinWeight(type)) || Convert.ToDouble(weight) > Convert.ToDouble(MaxWeight(type)))
        {
            return false;
        }

        return true;
    }

    public static void KeyPressSingleWord(object sender, KeyPressEventArgs e)
    {
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -
        if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    public static string SanatizeSQLString(string input)
    {
        // TODO: enhance security by also using SQL parmeters
        // https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?view=dotnet-plat-ext-6.0
        // XSS and SQL-I protection
        // Disallows >, <, ', ", ;, -

        while (input.Contains('>'))
        {
            input = input.Replace(">", "");
        }
        while (input.Contains('<'))
        {
            input = input.Replace("<", "");
        }
        while (input.Contains('\''))
        {
            input = input.Replace("'", "");
        }
        while (input.Contains('"'))
        {
            input = input.Replace("\"", "");
        }
        while (input.Contains(';'))
        {
            input = input.Replace(";", "");
        }
        while (input.Contains('-'))
        {
            input = input.Replace("-", "");
        }
        while (input.Contains('/'))
        {
            input = input.Replace("/", "");
        }
        while (input.Contains('*'))
        {
            input = input.Replace("*", "");
        }

        input = input.Trim();

        return input;
    }

}
