namespace Team_6_Senior_Project;
using System.Data;
internal class WindowSwapper
{   
    public static void ValidateWindow(string windowName)
    {
        if (windowName.Equals(Program.CurrentForm.Name, StringComparison.Ordinal))
            Program.CurrentForm = null;
    }

    public void GoToMainMenu(Form currentForm)
    {
        ChangeWindow(currentForm, new MainMenu());
    }

    public void GoToSpecimensForm(Form currentForm)
    {
        ChangeWindow(currentForm, new SpecimensForm());
    }

    public  void GoToTemplatesForm(Form currentForm)
    {
        ChangeWindow(currentForm, new TemplatesForm());
    }

    public void GoToSpecimensSummaryForm(Form currentForm)
    {
        ChangeWindow(currentForm, new SpecimensSummaryForm());
    }

    public void GoToSpecimensForm(Form currentForm, DataTable csvData)
    {
        ChangeWindow(currentForm, new SpecimensForm(csvData));
    }

    private static void ChangeWindow(Form currentWindow, Form newWindow)
    {
        Program.CurrentForm = newWindow;
        currentWindow.Close();
    }
}
