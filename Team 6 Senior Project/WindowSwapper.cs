namespace Team_6_Senior_Project;
internal class WindowSwapper
{
    public static void ValidateWindow(String windowName)
    {
        if (windowName.Equals(Program.CurrentForm.Name))
            Program.CurrentForm = null;
    }

    public static void GoToMainMenu(Form currentForm)
    {
        ChangeWindow(currentForm,new MainMenu());
    }

    public static void GoToSpecimensForm(Form currentForm)
    {
        ChangeWindow(currentForm, new SpecimensForm());
    }

    public static void GoToTemplatesForm(Form currentForm)
    {
        ChangeWindow(currentForm, new TemplatesForm());
    }

    public static void GoToSpecimensSummaryForm(Form currentForm)
    {
        ChangeWindow(currentForm, new SpecimensSummaryForm());
    }

    public static void GoToSpecimensForm(Form currentForm, string FileName)
    {
        ChangeWindow(currentForm, new SpecimensForm(FileName));
    }
    
    private static void ChangeWindow(Form currentWindow, Form newWindow)
    {
        Program.CurrentForm = newWindow;
        currentWindow.Close();
    }
}
